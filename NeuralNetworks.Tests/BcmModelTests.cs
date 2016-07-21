using System;
using FluentAssertions;
using MathNet.Numerics.LinearAlgebra;
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
            
            bcmModel.CorrelationMatrix.ColumnCount.ShouldBeEquivalentTo(6);
        }

        [Fact]
        public void SecondTrainedVectorShouldGiveRightMatrix()
        {
            var bcmModel = new BcmModel();
            var correctMatrix = Matrix<float>.Build.DenseOfArray(new[,]
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
            
            bcmModel.CorrelationMatrix.ShouldBeEquivalentTo(correctMatrix);
        }

        [Fact]
        public void SecondTrainedVectorWithOtherLengthShouldThrowException()
        {
            var bcmModel = new BcmModel();
            var vectorWithOtherLength = Vector<float>.Build.Dense(8);

            bcmModel.Train(_firstVector);
            
            Action trainingWithDifferentLengths = () => bcmModel.Train(vectorWithOtherLength);

            trainingWithDifferentLengths.ShouldThrow<ArgumentException>();
        }

        [Fact]
        public void TrainShouldThrowExceptionIfMatrixAlreadyKnowsTwoVectors()
        {
            var bcmModel = new BcmModel();
            var thirdVector = Vector<float>.Build.Dense(6);

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Action trainingWithKnownVector = () => bcmModel.Train(thirdVector);

            trainingWithKnownVector.ShouldThrow<InvalidOperationException>();
        }

        [Fact]
        public void TrainShouldThrowExceptionIfVectorValuesAreNotEqualZeroOrOne()
        {
            var bcmModel = new BcmModel();
            Vector<float> vectorWithBadValues = Vector<float>.Build.DenseOfArray(new[] { 1f, 1, 4, 0, 0, 0 });

            Action trainingWithBadValues = () => bcmModel.Train(vectorWithBadValues);

            trainingWithBadValues.ShouldThrow<ArgumentException>();
        }

        [Fact]
        public void ReturnTrueIfFirstVectorIsKnown()
        {
            var bcmModel = new BcmModel();
            var threshold = 2;

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            bcmModel.Test(_firstVector, threshold).Should().BeTrue();
        }

        [Fact]
        public void ReturnTrueIfSecondVectorIsKnown()
        {
            var bcmModel = new BcmModel();
            var threshold = 2;

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            bcmModel.Test(_secondVector, threshold).Should().BeTrue();
        }

        [Fact]
        public void ReturnFalseIfVectorIsNotKnown()
        {
            var bcmModel = new BcmModel();
            var threshold = 2;
            var unknownVector = Vector<float>.Build.DenseOfArray(new[] { 1f, 1, 1, 1, 0, 0 });

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            bcmModel.Test(unknownVector, threshold).Should().BeFalse();
        }

        [Fact]
        public void TestMethodShouldThrowExceptionIfVectorHaveDifferentLength()
        {
            var bcmModel = new BcmModel();
            var threshold = 2;
            var vectorWithOtherLength = Vector<float>.Build.Dense(8);

            bcmModel.Train(_firstVector);
            bcmModel.Train(_secondVector);

            Action testingWithDifferentLengths = () => bcmModel.Test(vectorWithOtherLength, threshold);

            testingWithDifferentLengths.ShouldThrow<ArgumentException>();
        }
    }
}
