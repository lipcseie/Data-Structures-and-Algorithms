using MergeSort;
using QuickSort;

namespace DSA.Test
{
    public class QuickSortTest
    {
        [Fact]
        [Trait("Category", "QuickTest")]
        public void QuickSort_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { 5, 2, 9, 1, 5, 6 };
            int[] expectedOutput = { 1, 2, 5, 5, 6, 9 };

            // Act
            QuickSortClass.QuickSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "QuickTest")]
        public void QuickSort_EmptyArray_DoesNotChange()
        {
            //Arrange
            int[] input = new int[0];
            int[] expectedOutput = new int[0];

            // Act
            QuickSortClass.QuickSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "QuickSortTest")]
        public void QuickSort_SingleElementArray_DoesNotChange()
        {
            // Arrange
            int[] input = { 42 };
            int[] expectedOutput = { 42 };

            // Act
            QuickSortClass.QuickSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }
    }
}
