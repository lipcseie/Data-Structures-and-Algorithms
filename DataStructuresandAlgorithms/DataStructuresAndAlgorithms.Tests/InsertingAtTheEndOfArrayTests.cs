using DataStructuresandAlgorithms.Arrays;

namespace DataStructuresAndAlgorithms.Tests
{
    public class InsertingAtTheEndOfArrayTests
    {
        [Fact]
        public void CreateArray_InsertsCorrectly()
        {
            // Arrange
            var insertingAtTheEndOfArray = new InsertingAtTheEndOfArray();

            // Act
            var array = insertingAtTheEndOfArray.CreateArray();
            var result = new int[] { 1, 2, 3, 8, 0, 0 };

            // Assert
            Assert.Equal(result, array);

        }
    }
}