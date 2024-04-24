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

            // Assert
            Assert.Equal(new int[] {1, 2, 3, 8, 0, 0}, array);

        }
    }
}