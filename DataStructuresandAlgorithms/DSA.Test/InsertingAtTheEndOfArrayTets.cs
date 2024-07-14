using InsertingAtTheEndOfArray;

namespace DSA.Test
{
    public class InsertingAtTheEndOfArrayTets
    {
        [Fact]
        [Trait("Category", "InsertingAtTheEndOfArrayTets")]
        public void InsertingAtTheEndOfArray_ShouldInsertElement()

        {
            // Arrange
            int[] originalArray = { 1, 2, 3 };
            int newElement = 9;
            int[] expcetedArray = { 1, 2, 3, 9 };

            // Act 
            int[] result = Program.InsertingAtTheEndOfArray(originalArray, newElement);

            // Assert

            Assert.Equal(expcetedArray, result);
            Assert.Equal(originalArray.Length + 1, result.Length);
        }

        [Fact]
        [Trait("Category", "InsertingAtTheEndOfArrayTets")]
        public void InsertingAtTheEndOfArray_EmptyArray_ShouldThrowException()
        {
            // Arrange
            int[] originalArray = { };
            int newElement = 9;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.InsertingAtTheEndOfArray(originalArray, newElement));
        }

        [Fact]
        [Trait("Category", "InsertingAtTheEndOfArrayTets")]
        public void InsertingAtTheEndOfArray_NullArray_ShouldThrowExeption()
        {
            // Arrange
            int[] originalArray = null;
            int newElement = 9;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.InsertingAtTheEndOfArray(originalArray, newElement));
        }

    }
}