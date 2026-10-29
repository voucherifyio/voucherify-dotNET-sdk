using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Voucherify.Test
{
    [Collection("RequiresClientCredentials")]
    public class LoyaltyV2FixtureTest
    {
        [SkippableFact]
        public async Task SetupAndTeardownCreatesProgramResources()
        {
            Skip.If(!LoyaltyV2Http.HasCredentials, "Client credentials not provided");

            LoyaltyV2Fixture.Context ctx = await LoyaltyV2Fixture.SetupAsync();
            try
            {
                ctx.ProgramId.Should().NotBeNullOrEmpty().And.StartWith("lprg_");
                ctx.CardDefinitionId.Should().NotBeNullOrEmpty().And.StartWith("lcdef_");
                ctx.RewardCardDefinitionId.Should().NotBeNullOrEmpty().And.StartWith("lcdef_");
                ctx.EarningRuleId.Should().NotBeNullOrEmpty().And.StartWith("lern_");
                ctx.RewardId.Should().NotBeNullOrEmpty().And.StartWith("lrew_");
            }
            finally
            {
                await LoyaltyV2Fixture.TeardownAsync(ctx);
            }
        }
    }
}
