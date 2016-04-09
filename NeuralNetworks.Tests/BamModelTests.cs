using MathNet.Numerics.LinearAlgebra;
using System;
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

            bamModel.Train(_image1, _name1);

            _output.WriteLine(bamModel.WeightsMatrix.ToString());
            Assert.Equal(6, bamModel.WeightsMatrix.RowCount);
            Assert.Equal(4, bamModel.WeightsMatrix.ColumnCount);
        }

        [Fact]
        public void SecondTrainingShouldGiveRightWeightMatrix()
        {
            var bamModel = new BamModel();
            var rightMatrix = Matrix<float>.Build.DenseOfArray(new[,]
            {
                {0f, -2, 2, 0},
                {0, 2, -2, 0},
                {0, 2, -2, 0},
                {2, 0, 0, -2},
                {-2, 0, 0, 2},
                {0, 2, -2, 0}
            });

            bamModel.Train(_image1, _name1);
            bamModel.Train(_image2, _name2);

            _output.WriteLine(bamModel.WeightsMatrix.ToString());
            Assert.Equal(rightMatrix, bamModel.WeightsMatrix);
        }

        [Fact]
        public void TrainingByImageWithBadLengthShouldThrowArgumentException()
        {
            var bamModel = new BamModel();
            var imageWithBadLength = Vector<float>.Build.DenseOfArray(new float[3]);

            bamModel.Train(_image1, _name1);

            Assert.Throws<ArgumentException>(() => bamModel.Train(imageWithBadLength, _name2));
        }

        [Fact]
        public void TrainingByNameWithBadLengthShouldThrowArgumentException()
        {
            var bamModel = new BamModel();
            var nameWithBadLength = Vector<float>.Build.DenseOfArray(new float[5]);

            bamModel.Train(_image1, _name1);

            Assert.Throws<ArgumentException>(() => bamModel.Train(_image2, nameWithBadLength));
        }

        [Fact]
        public void RecoveringNameWithOneGivenImageVectorShouldReturnRightName()
        {
            var bamModel = new BamModel();
            var imagesMatrix = Matrix<float>.Build.DenseOfRowVectors(_image1);
            var namesMatrix = Matrix<float>.Build.DenseOfRowVectors(_name1);

            bamModel.Train(_image1, _name1);
            bamModel.Train(_image2, _name2);

            Matrix<float> resultNamesMatrix = bamModel.RecoverName(imagesMatrix);
            _output.WriteLine(resultNamesMatrix.ToString());

            Assert.Equal(namesMatrix, resultNamesMatrix);
        }

        [Fact]
        public void RecoveringNameWithTwoGivenImageVectorsShouldReturnRightNames()
        {
            var bamModel = new BamModel();
            var imagesMatrix = Matrix<float>.Build.DenseOfRowVectors(_image1, _image2);
            var namesMatrix = Matrix<float>.Build.DenseOfRowVectors(_name1, _name2);

            bamModel.Train(_image1, _name1);
            bamModel.Train(_image2, _name2);

            Matrix<float> resultNamesMatrix = bamModel.RecoverName(imagesMatrix);
            _output.WriteLine(resultNamesMatrix.ToString());

            Assert.Equal(namesMatrix, resultNamesMatrix);
        }

        [Fact]
        public void RecoveringNameFromImageVectorWithWrongLengthShouldThrowArgumentException()
        {
            var bamModel = new BamModel();
            var imagesMatrixWithWrongColumnLength = Matrix<float>.Build.DenseOfArray(new float[1, 10]);

            bamModel.Train(_image1, _name1);

            Assert.Throws<ArgumentException>(() => bamModel.RecoverName(imagesMatrixWithWrongColumnLength));
        }

        [Fact]
        public void RecoveringImageWithOneGivenNameVectorShouldReturnRightImage()
        {
            var bamModel = new BamModel();
            var namesMatrix = Matrix<float>.Build.DenseOfRowVectors(_name1);
            var imagesMatrix = Matrix<float>.Build.DenseOfRowVectors(_image1);

            bamModel.Train(_image1, _name1);
            bamModel.Train(_image2, _name2);

            Matrix<float> resultNamesMatrix = bamModel.RecoverImage(namesMatrix);
            _output.WriteLine(resultNamesMatrix.ToString());

            Assert.Equal(imagesMatrix, resultNamesMatrix);
        }

        [Fact]
        public void RecoveringImageWithTwoGivenNameVectorsShouldReturnRightImages()
        {
            var bamModel = new BamModel();
            var namesMatrix = Matrix<float>.Build.DenseOfRowVectors(_name1, _name2);
            var imagesMatrix = Matrix<float>.Build.DenseOfRowVectors(_image1, _image2);

            bamModel.Train(_image1, _name1);
            bamModel.Train(_image2, _name2);

            Matrix<float> resultNamesMatrix = bamModel.RecoverImage(namesMatrix);
            _output.WriteLine(resultNamesMatrix.ToString());

            Assert.Equal(imagesMatrix, resultNamesMatrix);
        }

        [Fact]
        public void RecoveringImageFromNameVectorWithWrongLengthShouldThrowArgumentException()
        {
            var bamModel = new BamModel();
            var namesMatrixWithWrongColumnLength = Matrix<float>.Build.DenseOfArray(new float[1, 10]);

            bamModel.Train(_image1, _name1);

            Assert.Throws<ArgumentException>(() => bamModel.RecoverName(namesMatrixWithWrongColumnLength));
        }
    }
}
