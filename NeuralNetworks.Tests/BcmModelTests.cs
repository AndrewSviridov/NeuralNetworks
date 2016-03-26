using System;
using Xunit;

namespace NeuralNetworks.Tests
{
    public class BcmModelTests
    {
        private const int _size = 6;
        private readonly int[] _firstVector = { 1, 1, 0, 0, 0, 0 };
        private readonly int[] _secondVector = { 0, 1, 0, 0, 0, 1 };

        [Fact]
        public void FirstTrainedVectorShouldGiveMatrixSize()
        {
            var bcmModel = new BcmModel();

            bcmModel.Train(_firstVector);

            Assert.Equal(6, bcmModel.CorrelationMatrix.GetLength(0));
        }

        [Fact]
        public void SecondTrainedVectorShouldGiveRightMatrix()
        {
            var rightMatrix = new int[_size][];
            var bcmModel = new BcmModel();

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            rightMatrix[0] = new[] {1, 1, 0, 0, 0, 0};
            rightMatrix[1] = new[] {1, 1, 0, 0, 0, 1};
            rightMatrix[2] = new[] {0, 0, 0, 0, 0, 0};
            rightMatrix[3] = new[] {0, 0, 0, 0, 0, 0};
            rightMatrix[4] = new[] {0, 0, 0, 0, 0, 0};
            rightMatrix[5] = new[] {0, 1, 0, 0, 0, 1};

            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    Assert.Equal(rightMatrix[i][j], bcmModel.CorrelationMatrix[i,j]);
                }
            }
        }

        [Fact]
        public void SecondTrainedVectorWithOtherLengthShouldThrowException()
        {
            var bcmModel = new BcmModel();
            var vectorWithOtherLength = new int[8];

            bcmModel.Train(_firstVector);

            Assert.Throws<ArgumentException>(() => bcmModel.Train(vectorWithOtherLength));
        }

        [Fact]
        public void TrainShouldThrowExceptionIfMatrixAlreadyKnowsTwoVectors()
        {
            var bcmModel = new BcmModel();
            var thirdVector = new int[6];

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.Throws<InvalidOperationException>(() => bcmModel.Train(thirdVector));
        }

        [Fact]
        public void ReturnTrueIfFirstVectorIsKnown()
        {
            var bcmModel = new BcmModel();
            var threshold = 2;

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.True(bcmModel.Test(_firstVector, threshold));
        }

        [Fact]
        public void ReturnTrueIfSecondVectorIsKnown()
        {
            var bcmModel = new BcmModel();
            var threshold = 2;

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.True(bcmModel.Test(_secondVector, threshold));
        }

        [Fact]
        public void ReturnFalseIfVectorIsNotKnown()
        {
            var bcmModel = new BcmModel();
            var threshold = 2;
            var unknownVector = new[] {1, 1, 1, 0, 0, 0};

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.False(bcmModel.Test(unknownVector, threshold));
        }

        [Fact]
        public void TestMethodShouldThrowExceptionIfVectorHaveDifferentLength()
        {
            var bcmModel = new BcmModel();
            var threshold = 2;
            var vectorWithOtherLength = new int[7];

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.Throws<ArgumentException>(() => bcmModel.Test(vectorWithOtherLength, threshold));
        }
    }
}
