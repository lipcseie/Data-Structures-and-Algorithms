using DataStructuresandAlgorithms.Arrays;

namespace DataStructuresAndAlgorithms.Tests
{
    public class ArrayTests
    {
        [Fact]
        public void CreateArray_InsertsCorrectly_At_The_End()
        {
            // Arrange
            var insertingAtTheEndOfArray = new InsertingAtTheEndOfArray();

            // Act
            var array = insertingAtTheEndOfArray.CreateArray();
            var result = new int[] { 1, 2, 3, 4, 5, 8 };

            // Assert
            Assert.Equal(result, array);

        }

        [Fact]
        public void CreateArray_InsertsCorrectly_At_The_Start()
        {
            //Arrange
            var insertingAtTheStartOfArray = new InsertingAtTheStartOfArray();

            // Act
            var array = insertingAtTheStartOfArray.CreateArray();
            var result = new int[] { 20, 1, 2, 3, 4, 5 };

            // Assert
            Assert.Equal(result, array);
        }

        [Fact]
        public void CreateArray_InsertsCorrectly_Anywhere()
        {
            //Arrange
            var InsertingAnywhere = new InsertingAnywhere();

            //Act
            var array = InsertingAnywhere.CreateArray();
            var result = new int[] { 1, 2, 8, 3, 4, 5 };

            //Assert
            Assert.Equal(result, array);
        }
            
    }
}