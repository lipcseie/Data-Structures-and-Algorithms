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
        public void CreateArray_ReturnsArrayWithCorrectLength()
        {
            // Arrange
            var insertingAtTheStartOfArray = new InsertingAtTheStartOfArray();

            // Act
            var array = insertingAtTheStartOfArray.CreateArray();

            // Assert
            Assert.Equal(6, array.Length);
        }

        [Fact]
        public void CreateArray_InsertsCorrectly_Anywhere()
        {
            //Arrange
            var insertingAnywhere = new InsertingAnywhere();

            //Act
            var array = insertingAnywhere.CreateArray();
            var result = new int[] { 1, 2, 8, 3, 4, 5 };

            //Assert
            Assert.Equal(result, array);
        }

        [Fact]
        public void DeletionFromTheEnd_Deletes_Correctly_The_Last_Element()
        {
            //Arrange
            var deletionFromTheEnd = new DeletionFromTheEnd();

            //Act
            var array = deletionFromTheEnd.DeleteTheLastElement();
            var result = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Assert
            Assert.Equal(result, array);
        }

        [Fact]
        public void DeleteTheFirstElementFromTheArray_ReturnsCorrectArray()
        {
            // Arrange
            var deleteTheFirstElement = new DeleteTheFirstElement();

            // Act
            var array = deleteTheFirstElement.DeleteTheFirstElementFromTheArray();
            var expected = new int[] { 2, 3, 4, 5, 6, 7, 8, 9 };

            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void DeleteTheFirstElementFromTheArray_ReturnsArrayWithCorrectLength()
        {
            // Arrange
            var deleteTheFirstElement = new DeleteTheFirstElement();

            // Act
            var array = deleteTheFirstElement.DeleteTheFirstElementFromTheArray();

            // Assert
            Assert.Equal(8, array.Length);
        }

    }
}