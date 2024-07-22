using InsertionSort;

namespace DSA.Test
{
    public class InsertionSortTest
    {
        [Fact]
        [Trait("Category", "InsertionSortTest")]
        public void InsertionSort_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { 5, 2, 9, 1, 5, 6 };
            int[] expectedOutput = { 1, 2, 5, 5, 6, 9 };

            // Act
            InsertionSortClass.InsertionSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "InsertionSortTest")]
        public void InsertionSort_EmptyArray_DoesNotChange()
        {
            //Arrange
            int[] input = new int[0];
            int[] expectedOutput = new int[0];

            // Act
            InsertionSortClass.InsertionSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "InsertionSortTest")]
        public void InsertionSort_SingleElementArray_DoesNotChange()
        {
            // Arrange
            int[] input = { 42 };
            int[] expectedOutput = { 42 };

            // Act
            InsertionSortClass.InsertionSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }
    }
}
