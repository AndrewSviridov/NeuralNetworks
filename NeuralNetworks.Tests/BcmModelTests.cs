using Xunit;

namespace NeuralNetworks.Tests
{
    public class BcmModelTests
    {
        [Fact]
        public void FirstTrainedVectorShouldGiveMatrixSize()
        {
            var vector = new[] {1, 1, 0, 0, 0, 0};
            var bcmModel = new BcmModel();

            bcmModel.Train(vector);

            Assert.Equal(6, bcmModel.CorrelationMatrix.GetLength(0));
        }

        [Fact]
        public void SecondTrainedVectorShouldGiveRightMatrix()
        {
            const int size = 6;
            var firstVector = new[] {1, 1, 0, 0, 0, 0};
            var secondVector = new[] {0, 1, 0, 0, 0, 1};
            var rightMatrix = new int[size][];
            var bcmModel = new BcmModel();

            bcmModel.Train(firstVector);
            bcmModel.Train(secondVector);

            rightMatrix[0] = new[] {1, 1, 0, 0, 0, 0};
            rightMatrix[1] = new[] {1, 1, 0, 0, 0, 1};
            rightMatrix[2] = new[] {0, 0, 0, 0, 0, 0};
            rightMatrix[3] = new[] {0, 0, 0, 0, 0, 0};
            rightMatrix[4] = new[] {0, 0, 0, 0, 0, 0};
            rightMatrix[5] = new[] {0, 1, 0, 0, 0, 1};

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Assert.Equal(rightMatrix[i][j], bcmModel.CorrelationMatrix[i,j]);
                }
            }
        }
    }
}
