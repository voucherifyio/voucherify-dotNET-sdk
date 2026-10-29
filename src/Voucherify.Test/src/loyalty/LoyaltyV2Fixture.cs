using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Voucherify.Test
{
    /// <summary>
    /// HTTP-only setup and teardown for Loyalty v2 e2e tests.
    /// </summary>
    public static class LoyaltyV2Fixture
    {
        public sealed class Context
        {
            public string Suffix { get; set; }
            public string ProgramId { get; set; }
            public string CardDefinitionId { get; set; }
            public string RewardCardDefinitionId { get; set; }
            public string EarningRuleId { get; set; }
            public string RewardId { get; set; }
            public string ProgramName { get; set; }
        }

        public static async Task<Context> SetupAsync()
        {
            string suffix = $"{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}_{TestHelper.GenerateRandomString(6)}";
            string programName = $"dotnet_sdk_lv2_program_{suffix}";
            string cardName = $"dotnet_sdk_lv2_card_{suffix}";
            string earningRuleName = $"dotnet_sdk_lv2_earn_{suffix}";
            string rewardName = $"dotnet_sdk_lv2_reward_{suffix}";

            var program = await LoyaltyV2Http.CreateProgram(new Dictionary<string, object>
            {
                ["name"] = programName
            }).ConfigureAwait(false);
            string programId = LoyaltyV2Http.Id(program);
            if (string.IsNullOrEmpty(programId))
            {
                throw new LoyaltyV2HttpException(0, "createProgram returned no id");
            }

            var spendCard = await LoyaltyV2Http.CreateCardDefinition(
                BuildCardDefinitionBody(cardName, enablePayWithPoints: true)).ConfigureAwait(false);
            string cardDefinitionId = LoyaltyV2Http.Id(spendCard);
            if (string.IsNullOrEmpty(cardDefinitionId))
            {
                throw new LoyaltyV2HttpException(0, "createCardDefinition returned no id");
            }

            await LoyaltyV2Http.ActivateCardDefinition(cardDefinitionId).ConfigureAwait(false);

            var rewardCard = await LoyaltyV2Http.CreateCardDefinition(
                BuildCardDefinitionBody($"dotnet_sdk_lv2_reward_card_{suffix}", enablePayWithPoints: false))
                .ConfigureAwait(false);
            string rewardCardDefinitionId = LoyaltyV2Http.Id(rewardCard);
            if (string.IsNullOrEmpty(rewardCardDefinitionId))
            {
                throw new LoyaltyV2HttpException(0, "createCardDefinition (reward target) returned no id");
            }

            await LoyaltyV2Http.ActivateCardDefinition(rewardCardDefinitionId).ConfigureAwait(false);

            var earningRule = await LoyaltyV2Http.CreateEarningRule(
                BuildEarningRuleBody(earningRuleName, cardDefinitionId)).ConfigureAwait(false);
            string earningRuleId = LoyaltyV2Http.Id(earningRule);
            if (string.IsNullOrEmpty(earningRuleId))
            {
                throw new LoyaltyV2HttpException(0, "createEarningRule returned no id");
            }

            await LoyaltyV2Http.ActivateEarningRule(earningRuleId).ConfigureAwait(false);

            var reward = await LoyaltyV2Http.CreateReward(
                BuildRewardBody(rewardName, cardDefinitionId, rewardCardDefinitionId)).ConfigureAwait(false);
            string rewardId = LoyaltyV2Http.Id(reward);
            if (string.IsNullOrEmpty(rewardId))
            {
                throw new LoyaltyV2HttpException(0, "createReward returned no id");
            }

            await LoyaltyV2Http.ActivateReward(rewardId).ConfigureAwait(false);

            await LoyaltyV2Http.BatchAssignCardDefinitions(programId, new Dictionary<string, object>
            {
                ["assign"] = new object[]
                {
                    new Dictionary<string, object> { ["id"] = cardDefinitionId },
                    new Dictionary<string, object> { ["id"] = rewardCardDefinitionId }
                }
            }).ConfigureAwait(false);

            await LoyaltyV2Http.BatchAssignEarningRules(programId, new Dictionary<string, object>
            {
                ["assign"] = new object[]
                {
                    new Dictionary<string, object> { ["id"] = earningRuleId }
                }
            }).ConfigureAwait(false);

            await LoyaltyV2Http.BatchAssignRewards(programId, new Dictionary<string, object>
            {
                ["assign"] = new object[]
                {
                    new Dictionary<string, object>
                    {
                        ["id"] = rewardId,
                        ["stock"] = new Dictionary<string, object> { ["type"] = "UNLIMITED" }
                    }
                }
            }).ConfigureAwait(false);

            await LoyaltyV2Http.ActivateProgram(programId).ConfigureAwait(false);

            return new Context
            {
                Suffix = suffix,
                ProgramId = programId,
                CardDefinitionId = cardDefinitionId,
                RewardCardDefinitionId = rewardCardDefinitionId,
                EarningRuleId = earningRuleId,
                RewardId = rewardId,
                ProgramName = programName
            };
        }

        public static async Task TeardownAsync(Context ctx)
        {
            if (ctx == null)
            {
                return;
            }

            await IgnoreAsync("deactivateProgram", () => LoyaltyV2Http.DeactivateProgram(ctx.ProgramId))
                .ConfigureAwait(false);
            await IgnoreAsync("deleteProgram", () => LoyaltyV2Http.DeleteProgram(ctx.ProgramId))
                .ConfigureAwait(false);

            if (!string.IsNullOrEmpty(ctx.EarningRuleId))
            {
                await IgnoreAsync(
                    "deactivateEarningRule",
                    () => LoyaltyV2Http.DeactivateEarningRule(ctx.EarningRuleId)).ConfigureAwait(false);
            }

            if (!string.IsNullOrEmpty(ctx.RewardId))
            {
                await IgnoreAsync(
                    "deactivateReward",
                    () => LoyaltyV2Http.DeactivateReward(ctx.RewardId)).ConfigureAwait(false);
            }

            await Task.Delay(500).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(ctx.EarningRuleId))
            {
                await IgnoreAsync(
                    "deleteEarningRule",
                    () => LoyaltyV2Http.DeleteEarningRule(ctx.EarningRuleId)).ConfigureAwait(false);
            }

            if (!string.IsNullOrEmpty(ctx.RewardId))
            {
                await IgnoreAsync(
                    "deleteReward",
                    () => LoyaltyV2Http.DeleteReward(ctx.RewardId)).ConfigureAwait(false);
            }

            foreach (string cardId in new[] { ctx.CardDefinitionId, ctx.RewardCardDefinitionId })
            {
                if (!string.IsNullOrEmpty(cardId))
                {
                    await IgnoreAsync(
                        $"deleteCardDefinition {cardId}",
                        () => LoyaltyV2Http.DeleteCardDefinition(cardId)).ConfigureAwait(false);
                }
            }
        }

        private static Dictionary<string, object> BuildCardDefinitionBody(
            string name,
            bool enablePayWithPoints)
        {
            return new Dictionary<string, object>
            {
                ["name"] = name,
                ["type"] = "INDIVIDUAL",
                ["status"] = "DRAFT",
                ["points_expiration"] = new Dictionary<string, object> { ["type"] = "NO_EXPIRATION" },
                ["pending_points"] = new Dictionary<string, object> { ["type"] = "IMMEDIATE" },
                ["spending_limits"] = new Dictionary<string, object>
                {
                    ["global"] = new Dictionary<string, object>
                    {
                        ["type"] = "NO_LIMIT",
                        ["limits"] = null
                    },
                    ["transactions"] = new Dictionary<string, object>
                    {
                        ["type"] = "NO_LIMIT",
                        ["limits"] = null
                    }
                },
                ["pay_with_points"] = enablePayWithPoints
                    ? new Dictionary<string, object>
                    {
                        ["type"] = "EXCHANGE_RATIO",
                        ["exchange_ratio"] = new Dictionary<string, object> { ["formula"] = 1 }
                    }
                    : new Dictionary<string, object> { ["type"] = "NO_PAYMENTS" }
            };
        }

        private static Dictionary<string, object> BuildEarningRuleBody(
            string name,
            string cardDefinitionId)
        {
            return new Dictionary<string, object>
            {
                ["name"] = name,
                ["status"] = "DRAFT",
                ["trigger"] = new Dictionary<string, object> { ["event"] = "customer.order.paid" },
                ["earnings"] = new object[]
                {
                    new Dictionary<string, object>
                    {
                        ["effects"] = new object[]
                        {
                            new Dictionary<string, object>
                            {
                                ["type"] = "POINTS",
                                ["points"] = new Dictionary<string, object>
                                {
                                    ["value"] = 100,
                                    ["card_definition_id"] = cardDefinitionId
                                }
                            }
                        }
                    }
                }
            };
        }

        private static Dictionary<string, object> BuildRewardBody(
            string name,
            string spendCardDefinitionId,
            string creditCardDefinitionId)
        {
            return new Dictionary<string, object>
            {
                ["name"] = name,
                ["type"] = "DIGITAL",
                ["status"] = "DRAFT",
                ["material"] = null,
                ["digital"] = new Dictionary<string, object>
                {
                    ["type"] = "LOYALTY_CARD_POINTS",
                    ["discount_coupons"] = null,
                    ["gift_vouchers"] = null,
                    ["loyalty_card_points"] = new Dictionary<string, object>
                    {
                        ["points"] = 5,
                        ["card_definition_id"] = creditCardDefinitionId
                    }
                },
                ["costs"] = new object[]
                {
                    new Dictionary<string, object>
                    {
                        ["spending"] = new object[]
                        {
                            new Dictionary<string, object>
                            {
                                ["points"] = 10,
                                ["card_definition_id"] = spendCardDefinitionId
                            }
                        }
                    }
                }
            };
        }

        private static async Task IgnoreAsync(string label, Func<Task> action)
        {
            try
            {
                await action().ConfigureAwait(false);
            }
            catch (LoyaltyV2HttpException ex) when (ex.Status == 404)
            {
            }
            catch (LoyaltyV2HttpException ex)
            {
                Console.WriteLine($"Loyalty v2 teardown {label}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loyalty v2 teardown {label}: {ex.Message}");
            }
        }
    }
}
