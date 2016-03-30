using MathNet.Numerics.LinearAlgebra;
using System;
using Xunit;

namespace NeuralNetworks.Tests
{
    public class BcmModelTests
    {
        private const int _size = 6;
        private readonly Vector<float> _firstVector = Vector<float>.Build.DenseOfArray(new[] {1f, 1, 0, 0, 0, 0});
        private readonly Vector<float> _secondVector = Vector<float>.Build.DenseOfArray(new[] {0f, 1, 0, 0, 0, 1});

        [Fact]
        public void FirstTrainedVectorShouldGiveMatrixSize()
        {
            var bcmModel = new BcmModel();

            bcmModel.Train(_firstVector);

            Assert.Equal(6, bcmModel.CorrelationMatrix.ColumnCount);
        }

        [Fact]
        public void SecondTrainedVectorShouldGiveRightMatrix()
        {
            var bcmModel = new BcmModel();
            var rightMatrix = Matrix<float>.Build.DenseOfArray(new[,]
            {
                {1f, 1, 0, 0, 0, 0},
                {1, 1, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 1, 0, 0, 0, 1}
            });

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.Equal(rightMatrix, bcmModel.CorrelationMatrix);
        }

        [Fact]
        public void SecondTrainedVectorWithOtherLengthShouldThrowException()
        {
            var bcmModel = new BcmModel();
            var vectorWithOtherLength = Vector<float>.Build.Dense(8);

            bcmModel.Train(_firstVector);

            Assert.Throws<ArgumentException>(() => bcmModel.Train(vectorWithOtherLength));
        }

        [Fact]
        public void TrainShouldThrowExceptionIfMatrixAlreadyKnowsTwoVectors()
        {
            var bcmModel = new BcmModel();
            var thirdVector = Vector<float>.Build.Dense(6);

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.Throws<InvalidOperationException>(() => bcmModel.Train(thirdVector));
        }

        [Fact]
        public void TrainShouldThrowExceptionIfVectorValuesAreNotEqualZeroOrOne()
        {
            var bcmModel = new BcmModel();
            Vector<float> vectorWithBadValues = Vector<float>.Build.DenseOfArray(new[] { 1f, 1, 4, 0, 0, 0 });

            Assert.Throws<ArgumentException>(() => bcmModel.Train(vectorWithBadValues));
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
            var unknownVector = Vector<float>.Build.DenseOfArray(new[] { 1f, 1, 1, 1, 0, 0 });

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.False(bcmModel.Test(unknownVector, threshold));
        }

        [Fact]
        public void TestMethodShouldThrowExceptionIfVectorHaveDifferentLength()
        {
            var bcmModel = new BcmModel();
            var threshold = 2;
            var vectorWithOtherLength = Vector<float>.Build.Dense(8);

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Assert.Throws<ArgumentException>(() => bcmModel.Test(vectorWithOtherLength, threshold));
        }
    }
}
