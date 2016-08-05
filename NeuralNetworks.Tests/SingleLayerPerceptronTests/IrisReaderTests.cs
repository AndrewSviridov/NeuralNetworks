using System;
using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.SingleLayerPerceptronHelpers;
using Xunit;

namespace NeuralNetworks.Tests.SingleLayerPerceptronTests
{
    public class IrisReaderTests
    {
        private string _irisDataFolder = "Data/SingleLayerPerceptron/";
        private PerceptronVectorReader _irisReader = new PerceptronVectorReader();

        [Fact]
        public void ReadingDataShouldReturnCorrectVectors()
        {
            var correctIrises = new List<PerceptronVector>
            {
                new PerceptronVector(Vector<double>.Build.DenseOfArray(new[] { 7.0, 3.2, 4.7, 1.4 }), 1),
                new PerceptronVector(Vector<double>.Build.DenseOfArray(new[] { 6.4, 3.2, 4.5, 1.5 }), 1),
                new PerceptronVector(Vector<double>.Build.DenseOfArray(new[] { 6.9, 3.1, 4.9, 1.5 }), 1)
            };

            var readIrises = _irisReader.ReadFromTextFile(_irisDataFolder + "sampleIris.txt");

            readIrises.ShouldBeEquivalentTo(correctIrises);
        }

        [Fact]
        public void ReadingFromWrongFileShouldThrowFileNotFoundException()
        {
            Action readingNonExistentFile = () => _irisReader.ReadFromTextFile(_irisDataFolder + "file404.txt");

            readingNonExistentFile.ShouldThrow<FileNotFoundException>();
        }
    }
}
