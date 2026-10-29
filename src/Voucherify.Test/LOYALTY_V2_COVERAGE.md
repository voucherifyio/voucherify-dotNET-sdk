# Loyalty v2 e2e coverage (.NET SDK)

Migration map for Loyalty v2 tests under `Voucherify.Test`. Admin setup that is not on the published allowlist goes through `LoyaltyV2Http`; member and runtime calls use `LV2*Api`.

This is **not** a full API contract suite. Coverage is one happy-path flow against a live project.

## Files

| File | Role |
|------|------|
| `src/tests/LoyaltiesV2.cs` | Ordered xUnit suite (SDK runtime + light reports/examine) |
| `src/tests/LoyaltyV2FixtureTest.cs` | Optional HTTP setup/teardown smoke |
| `src/loyalty/LoyaltyV2Fixture.cs` | HTTP setup / teardown |
| `src/loyalty/LoyaltyV2Http.cs` | `HttpClient` for unpublished admin paths |
| `src/TestConfiguration.cs` | Credentials and host |

`npm run generate-sdk-dotnet` parks/restores `src/Voucherify.Test`, so this file and the tests stay when they are committed before regenerate. Do not add endpoints to `scripts/shared/get-take-list.ts` from this suite. Do not rewrite tests to call unpublished operations through the SDK.

## Client split

| Concern | Client | Why |
|---------|--------|-----|
| Program / card definition / earning rule / reward admin | **HTTP** (`LoyaltyV2Http`) | Not on the published .NET SDK allowlist |
| Member lifecycle, points, payments, purchases, examine, selected reports | **SDK** (`LV2ProgramsApi`, `LV2ExamineApi`, `LV2EarningRulesApi`) | Allowlisted Loyalty v2 operations |
| Test customer + order | **SDK** (`CustomersApi`, `OrdersApi`) | Existing v1 helpers |

## Depth legend

| Depth | Meaning |
|-------|---------|
| **Smoke** | Call succeeds; body present; light shape checks |
| **Basic** | Smoke + id/status/list membership checks |
| **Flow** | Multi-step happy path |
| **setup only** | Used to build the fixture; no separate assertion beyond setup ids |

---

## Covered via published SDK

### Members (`LV2ProgramsApi`)

| Method | HTTP | Depth | Notes |
|--------|------|-------|-------|
| `CreateProgramMemberAsync` | `POST .../members` | Flow | `customer_id` identification (set via property for serialize flag) |
| `GetProgramMemberAsync` | `GET .../members/{memberId}` | Basic | Id match; cards present |
| `ListProgramMembersAsync` | `GET .../members` | Basic | Created member in list |
| `GetProgramMembershipAsync` | `GET .../memberships/{customerId}` | Smoke | Response present |
| `ActivateProgramMemberAsync` | `POST .../activate` | Basic | Status becomes `ACTIVE` |
| `DeactivateProgramMemberAsync` | `POST .../deactivate` | Basic | Then re-activate for later steps |
| `DeleteProgramMemberAsync` | `DELETE .../members/{memberId}` | Smoke | Cleanup `Order(100)` |

Not covered: batch create members, update member, member activities, pending-point activate/cancel (fixture uses `pending_points.type = IMMEDIATE`).

### Cards / points (`LV2ProgramsApi`)

| Method | HTTP | Depth | Notes |
|--------|------|-------|-------|
| `AdjustCardPointsAsync` | `POST .../cards/{cardId}/points` | Flow | +100 admin credit; 3s wait |
| `ListCardTransactionsAsync` | `GET .../cards/{cardId}/transactions` | Basic | Non-empty after adjust |

### Order payments (`LV2ProgramsApi` + `OrdersApi`)

| Method | HTTP | Depth | Notes |
|--------|------|-------|-------|
| `CreateOrderAsync` | `POST /v1/orders` | Smoke | Fixture order |
| `CreateMemberOrderPaymentAsync` | `POST .../orders/payments` | Flow | `DRY_RUN`, `CARD_BALANCE` |
| `ListMemberOrderPaymentsAsync` | `GET .../orders/payments` | Smoke | Response present |

Requires spend card with `pay_with_points.type = EXCHANGE_RATIO` (fixture).

### Reward purchases (`LV2ProgramsApi`)

| Method | HTTP | Depth | Notes |
|--------|------|-------|-------|
| `PurchaseMemberRewardAsync` | `POST .../rewards/purchases` | Flow | Dry-run then transaction |
| `ListMemberRewardPurchasesAsync` | `GET .../rewards/purchases` | Basic | Poll until `APPROVED` |
| `RefundRewardPurchaseAsync` | `POST .../rewards/purchases/{id}/refund` | Flow | `policies.refund = ALLOW` |

### Examine (`LV2ExamineApi`)

| Method | HTTP | Depth |
|--------|------|-------|
| `ExamineEarningRulesAsync` | `POST /v2/loyalties/examine/earning-rules` | Smoke |
| `ExamineRewardsAsync` | `POST /v2/loyalties/examine/rewards` | Smoke |

### Reports (`LV2ProgramsApi`) — subset

| Method | Depth | Notes |
|--------|-------|-------|
| `ListProgramMembersSummaryReportsAsync` | Smoke | |
| `ListProgramRewardsSummaryReportsAsync` | Smoke | |
| `ListProgramMembersDailyReportsAsync` | Smoke | `start_date` strictly before `end_date`; empty list OK |
| `ListMemberCardDailyReportsAsync` | Smoke | Same date rules |

Daily report query params need `GlobalConfiguration.DateTimeFormat = "yyyy-MM-dd"` because `ParameterToMultiMap` formats `DateTimeOffset` via the global config.

### Optional GET (`LV2EarningRulesApi`)

| Method | HTTP | Depth |
|--------|------|-------|
| `GetEarningRuleAsync` | `GET /v2/loyalties/earning-rules/{id}` | Smoke |

---

## HTTP helper — migration map

When an operation is added to `scripts/shared/get-take-list.ts` and regenerated into the .NET SDK, replace the `LoyaltyV2Http` wrapper with the generated API class (`LV2ProgramsApi`, `LV2EarningRulesApi`, or `LV2RewardsApi` depending on the OpenAPI tag). Class names are `LV2*Api` (not `Lv2*`).

| `LoyaltyV2Http` | HTTP | Why HTTP today | Future SDK target | Depth |
|-----------------|------|----------------|-------------------|-------|
| `CreateProgram` | `POST /v2/loyalties/programs` | Not allowlisted | Programs admin create (generator name TBD) | setup only |
| `ActivateProgram` | `POST .../programs/{id}/activate` | Not allowlisted | Matching activate | setup only |
| `DeactivateProgram` | `POST .../programs/{id}/deactivate` | Not allowlisted | Matching deactivate | setup only |
| `DeleteProgram` | `DELETE .../programs/{id}` | Not allowlisted | Matching delete | setup only |
| `CreateCardDefinition` | `POST /v2/loyalties/card-definitions` | Not allowlisted | Card-definitions admin create | setup only |
| `ActivateCardDefinition` | `POST .../card-definitions/{id}/activate` | Not allowlisted | Matching activate | setup only |
| `DeleteCardDefinition` | `DELETE .../card-definitions/{id}` | Not allowlisted | Matching delete | setup only |
| `CreateEarningRule` | `POST /v2/loyalties/earning-rules` | Not allowlisted | Earning-rules admin create | setup only |
| `ActivateEarningRule` | `POST .../earning-rules/{id}/activate` | Not allowlisted | Matching activate | setup only |
| `DeactivateEarningRule` | `POST .../earning-rules/{id}/deactivate` | Not allowlisted | Matching deactivate | setup only |
| `DeleteEarningRule` | `DELETE .../earning-rules/{id}` | Not allowlisted | Matching delete | setup only |
| `CreateReward` | `POST /v2/loyalties/rewards` | Not allowlisted | Rewards admin create | setup only |
| `ActivateReward` | `POST .../rewards/{id}/activate` | Not allowlisted | Matching activate | setup only |
| `DeactivateReward` | `POST .../rewards/{id}/deactivate` | Not allowlisted | Matching deactivate | setup only |
| `DeleteReward` | `DELETE .../rewards/{id}` | Not allowlisted | Matching delete | setup only |
| `BatchAssignCardDefinitions` | `POST .../card-definitions/batch` | Not allowlisted | Batch assign on programs API | setup only |
| `BatchAssignEarningRules` | `POST .../earning-rules/batch` | Not allowlisted | Batch assign | setup only |
| `BatchAssignRewards` | `POST .../rewards/batch` | Not allowlisted | Batch assign | setup only |

Card definitions have no deactivate path in OpenAPI (activate + delete only).

### Teardown order (`LoyaltyV2Fixture.TeardownAsync` + suite `Order(100)`)

1. SDK: deactivate/delete member and delete customer (`LoyaltiesV2Test.CleanupAlwaysRuns`)
2. HTTP: deactivate + delete program (drops assignments)
3. HTTP: deactivate + delete earning rule and reward
4. HTTP: delete both card definitions

## How to run

From the OpenAPI repo (Docker, same `.env` as other .NET tests):

```bash
npm run test-dotnet-sdk
```

Or locally in `sdks/dotnet`:

```bash
dotnet test src/Voucherify.Test/Voucherify.Test.csproj --filter "FullyQualifiedName~LoyaltiesV2"
```
