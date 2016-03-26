using System;
using Xunit;

namespace NeuralNetworks.Tests
{
    public class NeuralNetworksMathTests
    {
        private readonly int[] _firstVector = { 1, 1, 0, 0, 0, 0 };
        private readonly int[] _secondVector = { 0, 1, 0, 0, 0, 1 };

        [Fact]
        public void MultiplyVectorByMatrixShouldGiveRightVector()
        {
            var bcmModel = new BcmModel();

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.Equal(new[] {1, 2, 0, 0, 0, 2},
                NeuralNetworksMath.MultiplyVectorByMatrix(_secondVector, bcmModel.CorrelationMatrix));
        }

        [Fact]
        public void ThrowExceptionIfMatrixLengthIsDifferentThanVectorLength()
        {
            var bcmModel = new BcmModel();
            var vectorWithDifferentLength = new int[8];

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.Throws<ArgumentException>(
                () => NeuralNetworksMath.MultiplyVectorByMatrix(vectorWithDifferentLength, bcmModel.CorrelationMatrix));
        }
    }
}
