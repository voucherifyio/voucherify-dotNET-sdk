using System.Collections.Generic;
using FluentAssertions;
using Voucherify.Model;
using Xunit;

namespace Voucherify.Test
{
    public class BackwardsCompatibilityTest
    {
        [Fact]
        public void ApplicableTo_Keeps_Previous_Positional_Constructor_Order()
        {
            List<int> orderItemIndices = new List<int> { 1 };
            List<ApplicableToOrderItemUnitsItem> orderItemUnits =
                new List<ApplicableToOrderItemUnitsItem>();

            ApplicableTo model = new ApplicableTo(
                null, null, null, null, null, null, null, default(ApplicableToEffect), null, null,
                null, null, orderItemIndices, orderItemUnits, 2, 3, null);

            model.OrderItemIndices.Should().BeEquivalentTo(orderItemIndices);
            model.OrderItemUnits.Should().BeSameAs(orderItemUnits);
            model.Repeat.Should().Be(2);
            model.SkipInitially.Should().Be(3);
        }

        [Fact]
        public void InapplicableTo_Keeps_Previous_Positional_Constructor_Order()
        {
            List<int> orderItemIndices = new List<int> { 1 };
            List<InapplicableToOrderItemUnitsItem> orderItemUnits =
                new List<InapplicableToOrderItemUnitsItem>();

            InapplicableTo model = new InapplicableTo(
                null, null, null, null, null, null, null, default(ApplicableToEffect), null, null,
                null, null, orderItemIndices, orderItemUnits, 2, 3, null);

            model.OrderItemIndices.Should().BeEquivalentTo(orderItemIndices);
            model.OrderItemUnits.Should().BeSameAs(orderItemUnits);
            model.Repeat.Should().Be(2);
            model.SkipInitially.Should().Be(3);
        }

        [Fact]
        public void SegmentResponses_Keep_Previous_Positional_Constructor_Order()
        {
            SegmentsCreateResponseBody createResponse =
                new SegmentsCreateResponseBody(
                    "segment-id",
                    "segment-name",
                    null,
                    SegmentsCreateResponseBody.TypeEnum.Static,
                    null,
                    SegmentsCreateResponseBody.ObjectEnum.Segment);
            SegmentsGetResponseBody getResponse =
                new SegmentsGetResponseBody(
                    "segment-id",
                    "segment-name",
                    null,
                    SegmentsGetResponseBody.TypeEnum.Static,
                    null,
                    SegmentsGetResponseBody.ObjectEnum.Segment);

            createResponse.Type.Should().Be(SegmentsCreateResponseBody.TypeEnum.Static);
            createResponse.Object.Should().Be(SegmentsCreateResponseBody.ObjectEnum.Segment);
            getResponse.Type.Should().Be(SegmentsGetResponseBody.TypeEnum.Static);
            getResponse.Object.Should().Be(SegmentsGetResponseBody.ObjectEnum.Segment);
        }
    }
}
