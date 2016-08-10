using System;
using FluentAssertions;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.Models;
using Xunit;
using Xunit.Abstractions;

namespace NeuralNetworks.Tests
{
    public class BamModelTests
    {
        private readonly ITestOutputHelper _output;
        private readonly Vector<float> _image1 = Vector<float>.Build.DenseOfArray(new[] {0f, 1, 1, 1, 0, 1});
        private readonly Vector<float> _image2 = Vector<float>.Build.DenseOfArray(new[] {1f, 0, 0, 1, 0, 0});
        private readonly Vector<float> _name1 = Vector<float>.Build.DenseOfArray(new[] {1f, 1, 0, 0});
        private readonly Vector<float> _name2 = Vector<float>.Build.DenseOfArray(new[] {1f, 0, 1, 0});

        public BamModelTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void FirstTrainingShouldSetMatrixDimensions()
        {
            var bamModel = new BamModel();

            bamModel.Teach(_image1, _name1);

            _output.WriteLine(bamModel.WeightsMatrix.ToString());
            bamModel.WeightsMatrix.RowCount.ShouldBeEquivalentTo(6);
            bamModel.WeightsMatrix.ColumnCount.ShouldBeEquivalentTo(4);
        }

        [Fact]
        public void SecondTrainingShouldGiveRightWeightMatrix()
        {
            var bamModel = new BamModel();
            var correctMatrix = Matrix<float>.Build.DenseOfArray(new[,]
            {
                {0f, -2, 2, 0},
                {0, 2, -2, 0},
                {0, 2, -2, 0},
                {2, 0, 0, -2},
                {-2, 0, 0, 2},
                {0, 2, -2, 0}
            });

            bamModel.Teach(_image1, _name1);
            bamModel.Teach(_image2, _name2);

            _output.WriteLine(bamModel.WeightsMatrix.ToString());
            bamModel.WeightsMatrix.ShouldBeEquivalentTo(correctMatrix);
        }

        [Fact]
        public void TrainingByImageWithBadLengthShouldThrowArgumentException()
        {
            var bamModel = new BamModel();
            var imageWithBadLength = Vector<float>.Build.DenseOfArray(new float[3]);

            bamModel.Teach(_image1, _name1);
            
            Action validatingImageLength = () => bamModel.Teach(imageWithBadLength, _name2);

            validatingImageLength.ShouldThrow<ArgumentException>();
        }

        [Fact]
        public void TrainingByNameWithBadLengthShouldThrowArgumentException()
        {
            var bamModel = new BamModel();
            var nameWithBadLength = Vector<float>.Build.DenseOfArray(new float[5]);

            bamModel.Teach(_image1, _name1);

            Action validatingImageLength = () => bamModel.Teach(_image2, nameWithBadLength);

            validatingImageLength.ShouldThrow<ArgumentException>();
        }

        [Fact]
        public void RecoveringNameWithOneGivenImageVectorShouldReturnRightName()
        {
            var bamModel = new BamModel();
            var imagesMatrix = Matrix<float>.Build.DenseOfRowVectors(_image1);
            var namesMatrix = Matrix<float>.Build.DenseOfRowVectors(_name1);

            bamModel.Teach(_image1, _name1);
            bamModel.Teach(_image2, _name2);

            Matrix<float> resultNamesMatrix = bamModel.RecoverName(imagesMatrix);
            _output.WriteLine(resultNamesMatrix.ToString());

            resultNamesMatrix.ShouldBeEquivalentTo(namesMatrix);
        }

        [Fact]
        public void RecoveringNameWithTwoGivenImageVectorsShouldReturnRightNames()
        {
            var bamModel = new BamModel();
            var imagesMatrix = Matrix<float>.Build.DenseOfRowVectors(_image1, _image2);
            var namesMatrix = Matrix<float>.Build.DenseOfRowVectors(_name1, _name2);

            bamModel.Teach(_image1, _name1);
            bamModel.Teach(_image2, _name2);

            Matrix<float> resultNamesMatrix = bamModel.RecoverName(imagesMatrix);
            _output.WriteLine(resultNamesMatrix.ToString());

            resultNamesMatrix.ShouldBeEquivalentTo(namesMatrix);
        }

        [Fact]
        public void RecoveringNameFromImageVectorWithWrongLengthShouldThrowArgumentException()
        {
            var bamModel = new BamModel();
            var imagesMatrixWithWrongColumnLength = Matrix<float>.Build.DenseOfArray(new float[1, 10]);

            bamModel.Teach(_image1, _name1);

            Action recoveringNameFromWrongImage = () => bamModel.RecoverName(imagesMatrixWithWrongColumnLength);

            recoveringNameFromWrongImage.ShouldThrow<ArgumentException>();
        }

        [Fact]
        public void RecoveringImageWithOneGivenNameVectorShouldReturnRightImage()
        {
            var bamModel = new BamModel();
            var namesMatrix = Matrix<float>.Build.DenseOfRowVectors(_name1);
            var imagesMatrix = Matrix<float>.Build.DenseOfRowVectors(_image1);

            bamModel.Teach(_image1, _name1);
            bamModel.Teach(_image2, _name2);

            Matrix<float> resultNamesMatrix = bamModel.RecoverImage(namesMatrix);
            _output.WriteLine(resultNamesMatrix.ToString());
            
            resultNamesMatrix.ShouldBeEquivalentTo(imagesMatrix);
        }

        [Fact]
        public void RecoveringImageWithTwoGivenNameVectorsShouldReturnRightImages()
        {
            var bamModel = new BamModel();
            var namesMatrix = Matrix<float>.Build.DenseOfRowVectors(_name1, _name2);
            var imagesMatrix = Matrix<float>.Build.DenseOfRowVectors(_image1, _image2);

            bamModel.Teach(_image1, _name1);
            bamModel.Teach(_image2, _name2);

            Matrix<float> resultNamesMatrix = bamModel.RecoverImage(namesMatrix);
            _output.WriteLine(resultNamesMatrix.ToString());

            resultNamesMatrix.ShouldBeEquivalentTo(imagesMatrix);
        }

        [Fact]
        public void RecoveringImageFromNameVectorWithWrongLengthShouldThrowArgumentException()
        {
            var bamModel = new BamModel();
            var namesMatrixWithWrongColumnLength = Matrix<float>.Build.DenseOfArray(new float[1, 10]);

            bamModel.Teach(_image1, _name1);
            
            Action recoveringImageFromWrongName = () => bamModel.RecoverImage(namesMatrixWithWrongColumnLength);

            recoveringImageFromWrongName.ShouldThrow<ArgumentException>();
        }
    }
}
