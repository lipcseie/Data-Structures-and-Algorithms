using MergeSort;

namespace DSA.Test
{
    public class MergSortTest
    {
        [Fact]
        [Trait("Category", "MergeSortTest")]
        public void MergeSort_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { 5, 2, 9, 1, 5, 6 };
            int[] expectedOutput = { 1, 2, 5, 5, 6, 9 };

            // Act
            MergeSortClass.MergeSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "MergeSortTest")]
        public void MergeSort_EmptyArray_DoesNotChange()
        {
            //Arrange
            int[] input = new int[0];
            int[] expectedOutput = new int[0];

            // Act
            MergeSortClass.MergeSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "MergeSortTest")]
        public void MergeSort_SingleElementArray_DoesNotChange()
        {
            // Arrange
            int[] input = { 42 };
            int[] expectedOutput = { 42 };

            // Act
            MergeSortClass.MergeSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "MergeSortTests")]
        public void MergeSort_AlreadySortedArray_DoesNotChange()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            MergeSortClass.MergeSort(input);

            // Assert
            Assert.Equal(expected, input);
        }

        [Fact]
        [Trait("Category", "MergeSortTests")]
        public void MergeSort_LargeArray_SortsCorretly()
        {
            // Arrange
            int[] input = Enumerable.Range(1, 1000).Reverse().ToArray();
            int[] expetedOutput = Enumerable.Range(1, 1000).ToArray();

            // Act
            MergeSortClass.MergeSort(input);

            // Assert
            Assert.Equal(expetedOutput, input);
        }

        [Fact]
        [Trait("Category", "MergeSortTests")]
        public void MergeSort_ArrayWithNegativeNumbers_SortsCorrectly()
        {
            // Arrange
            int[] input = { -3, -1, -2, 0, 2, 1 };
            int[] expetedOutput = { -3, -2, -1, 0, 1, 2 };

            // Act
            MergeSortClass.MergeSort(input);

            // Assert
            Assert.Equal(expetedOutput, input);
        }

    }
}
