using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;
using Xunit;
using Xunit.Extensions.Ordering;

namespace Voucherify.Test
{
    [TestCaseOrderer("Xunit.Extensions.Ordering.TestCaseOrderer", "Xunit.Extensions.Ordering")]
    [Collection("RequiresClientCredentials")]
    public class LoyaltiesV2Test
    {
        private static LV2ProgramsApi _programsApi;
        private static CustomersApi _customersApi;

        private static LoyaltyV2Fixture.Context _fixtureCtx;
        private static CustomersCreateResponseBody _customer;
        private static V2LoyaltiesProgramsMembersGetResponseBody _member;
        private static string _memberId;
        private static string _primaryCardId;
        private static bool _setupComplete;

        public LoyaltiesV2Test()
        {
            if (_programsApi == null)
            {
                Configuration config = TestConfiguration.GetClientConfiguration();
                _programsApi = new LV2ProgramsApi(config);
                _customersApi = new CustomersApi(config);
            }
        }

        [SkippableFact, Order(1)]
        public async Task SetupCreatesActivatedProgramResources()
        {
            Skip.If(!LoyaltyV2Http.HasCredentials, "Client credentials not provided");

            if (!_setupComplete)
            {
                _fixtureCtx = await LoyaltyV2Fixture.SetupAsync();

                var customerBody = new CustomersCreateRequestBody(
                    sourceId: $"lv2_customer_{_fixtureCtx.Suffix}",
                    name: "Loyalty v2 .NET SDK test");
                _customer = await _customersApi.CreateCustomerAsync(customerBody);

                // Set via property so ShouldSerializeCustomerIdentification is true
                // (ctor assigns the backing field without flipping the serialize flag).
                var memberBody = new V2LoyaltiesProgramsMembersCreateRequestBody
                {
                    CustomerIdentification = new Dictionary<string, object>
                    {
                        ["type"] = "customer_id",
                        ["customer_id"] = _customer.Id,
                        ["customer_source_id"] = null
                    }
                };

                V2LoyaltiesProgramsMembersCreateResponseBody created =
                    await _programsApi.CreateProgramMemberAsync(_fixtureCtx.ProgramId, memberBody);
                _memberId = created.Id;
                _member = await _programsApi.GetProgramMemberAsync(_fixtureCtx.ProgramId, _memberId);
                _primaryCardId = ResolvePrimaryCardId(_member.Cards, _fixtureCtx.CardDefinitionId);
                _setupComplete = true;
            }

            _fixtureCtx.ProgramId.Should().NotBeNullOrEmpty().And.StartWith("lprg_");
            _fixtureCtx.CardDefinitionId.Should().StartWith("lcdef_");
            _fixtureCtx.EarningRuleId.Should().StartWith("lern_");
            _fixtureCtx.RewardId.Should().StartWith("lrew_");
            _memberId.Should().NotBeNullOrEmpty();
            _customer.Id.Should().NotBeNullOrEmpty();
        }

        [SkippableFact, Order(2)]
        public async Task MemberLifecycleViaSdk()
        {
            Skip.If(!_setupComplete, "Loyalty v2 setup did not run");

            _memberId.Should().NotBeNullOrEmpty();
            _member.CustomerId.Should().Be(_customer.Id);
            _member.Cards.Should().NotBeNullOrEmpty();

            V2LoyaltiesProgramsMembersGetResponseBody fetched =
                await _programsApi.GetProgramMemberAsync(_fixtureCtx.ProgramId, _memberId);
            fetched.Id.Should().Be(_memberId);

            V2LoyaltiesProgramsMembersListResponseBody listed =
                await _programsApi.ListProgramMembersAsync(_fixtureCtx.ProgramId);
            listed.Data.Should().Contain(item => item.Id == _memberId);

            V2LoyaltiesProgramsMembershipsGetResponseBody membership =
                await _programsApi.GetProgramMembershipAsync(_fixtureCtx.ProgramId, _customer.Id);
            membership.Should().NotBeNull();

            if (_member.Status == V2LoyaltiesProgramsMembersGetResponseBody.StatusEnum.INACTIVE)
            {
                V2LoyaltiesProgramsMembersActivateResponseBody activated =
                    await _programsApi.ActivateProgramMemberAsync(_fixtureCtx.ProgramId, _memberId);
                activated.Status.Should().NotBeNull();
            }

            await _programsApi.DeactivateProgramMemberAsync(_fixtureCtx.ProgramId, _memberId);
            await _programsApi.ActivateProgramMemberAsync(_fixtureCtx.ProgramId, _memberId);

            _member = await _programsApi.GetProgramMemberAsync(_fixtureCtx.ProgramId, _memberId);
            _member.Status.Should().Be(V2LoyaltiesProgramsMembersGetResponseBody.StatusEnum.ACTIVE);
            _primaryCardId = ResolvePrimaryCardId(_member.Cards, _fixtureCtx.CardDefinitionId);
            _primaryCardId.Should().StartWith("lcrd_");
        }

        [SkippableFact, Order(100)]
        public async Task CleanupMemberAndCustomer()
        {
            Skip.If(!_setupComplete && _fixtureCtx == null, "Nothing to clean up");

            await IgnoreAsync("deactivateProgramMember", async () =>
            {
                if (_fixtureCtx != null && !string.IsNullOrEmpty(_memberId))
                {
                    await _programsApi.DeactivateProgramMemberAsync(_fixtureCtx.ProgramId, _memberId);
                }
            });
            await IgnoreAsync("deleteProgramMember", async () =>
            {
                if (_fixtureCtx != null && !string.IsNullOrEmpty(_memberId))
                {
                    await _programsApi.DeleteProgramMemberAsync(_fixtureCtx.ProgramId, _memberId);
                }
            });
            await IgnoreAsync("deleteCustomer", async () =>
            {
                if (_customer != null)
                {
                    await _customersApi.CustomerPermanentlyDeletionAsync(_customer.Id);
                }
            });

            // Program HTTP teardown is owned by prompt 06 so later suite steps can share the fixture.
            _member = null;
            _memberId = null;
            _customer = null;
            _primaryCardId = null;
            _setupComplete = false;
        }

        private static string ResolvePrimaryCardId(
            List<MemberCard> cards,
            string cardDefinitionId)
        {
            if (cards == null || cards.Count == 0)
            {
                throw new InvalidOperationException("No loyalty card on member");
            }

            MemberCard match = cards.FirstOrDefault(
                entry => entry?.Card?.CardDefinitionId == cardDefinitionId);
            string id = (match ?? cards[0])?.Card?.Id;
            if (string.IsNullOrEmpty(id))
            {
                throw new InvalidOperationException("No loyalty card id on member");
            }

            return id;
        }

        private static async Task IgnoreAsync(string label, Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (ApiException ex) when (ex.ErrorCode == 404)
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loyalty v2 cleanup {label}: {ex.Message}");
            }
        }
    }
}
