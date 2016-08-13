using System;
using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using MathNet.Numerics.LinearAlgebra;
using NeuralNetworks.Utility;
using Xunit;
using Xunit.Abstractions;

namespace NeuralNetworks.Tests.SingleLayerPerceptronTests
{
    public class DataReaderTests
    {
        private string _dataFolder = "Data/";
        private DataReader _dataReader = new DataReader();
        private ITestOutputHelper _output;

        public DataReaderTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void ReadingPerceptronDataShouldReturnCorrectVectors()
        {
            var correctData = new List<NeuralVector>
            {
                new NeuralVector(Vector<double>.Build.DenseOfArray(new[] { 7.0, 3.2, 4.7, 1.4 }), 1),
                new NeuralVector(Vector<double>.Build.DenseOfArray(new[] { 6.4, 3.2, 4.5, 1.5 }), 1),
                new NeuralVector(Vector<double>.Build.DenseOfArray(new[] { 6.9, 3.1, 4.9, 1.5 }), 1)
            };

            var readData = _dataReader.ReadPerceptronDataFromTextFile(_dataFolder + "sampleSLP.txt", '\t', '.');

            readData.ShouldBeEquivalentTo(correctData);
        }

        [Fact]
        public void ReadingHopfieldDataShouldReturnCorrectVectors()
        {
            var correctData = new List<NeuralVector>
            {
                new NeuralVector(Vector<double>.Build.DenseOfArray(new[] { 1.0, -1, -1, 1 })),
                new NeuralVector(Vector<double>.Build.DenseOfArray(new[] { -1.0, 1, 1, 1 })),
                new NeuralVector(Vector<double>.Build.DenseOfArray(new[] { 1.0, -1, 1, 1 }))
            };

            var readData = _dataReader.ReadHopfieldDataFromTextFile(_dataFolder + "sampleHopfield.txt", '\t');

            readData.ShouldBeEquivalentTo(correctData);
        }

        [Fact]
        public void ReadingFromWrongFileShouldThrowFileNotFoundException()
        {
            Action readingNonExistentFile = () => _dataReader.ReadPerceptronDataFromTextFile(_dataFolder + "file404.txt", '\t', '.');

            readingNonExistentFile.ShouldThrow<FileNotFoundException>();
        }
    }
}
