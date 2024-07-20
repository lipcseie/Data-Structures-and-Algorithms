using BubbleSort;
using SelectionSort;


namespace DSA.Test
{
    public class SelectionSortTests
    {
        [Fact]
        [Trait("Category", "SelectionSortTests")]
        public void SelectionSort_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { 5, 2, 9, 1, 5, 6 };
            int[] expectedOutput = { 1, 2, 5, 5, 6, 9 };

            // Act
            SelectionSortClass.SelectionSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "SelectionSortTests")]
        public void SelectionSort_EmptyArray_DoesNotChange()
        {
            //Arrange
            int[] input = new int[0];
            int[] expectedOutput = new int[0];

            // Act
            SelectionSortClass.SelectionSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "SelectionSortTests")]
        public void SelectionSort_SingleElementArray_DoesNotChange()
        {
            // Arrange
            int[] input = { 42 };
            int[] expectedOutput = { 42 };

            // Act
            BubbleSortClass.BubbleSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "SelectionSortTests")]
        public void SelectionSort_AlreadySortedArray_DoesNotChange()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            SelectionSortClass.SelectionSort(input);

            // Assert
            Assert.Equal(expected, input);
        }

        [Fact]
        [Trait("Category", "SelectionSortTests")]
        public void SelectionSort_LargeArray_SortsCorretly()
        {
            // Arrange
            int[] input = Enumerable.Range(1, 1000).Reverse().ToArray();
            int[] expetedOutput = Enumerable.Range(1, 1000).ToArray();

            // Act
            SelectionSortClass.SelectionSort(input);

            // Assert
            Assert.Equal(expetedOutput, input);
        }

        [Fact]
        [Trait("Category", "SelectionSortTests")]
        public void SelectionSort_ArrayWithNegativeNumbers_SortsCorrectly()
        {
            // Arrange
            int[] input = { -3, -1, -2, 0, 2, 1 };
            int[] expetedOutput = { -3, -2, -1, 0, 1, 2 };

            // Act
            SelectionSortClass.SelectionSort(input);

            // Assert
            Assert.Equal(expetedOutput, input);
        }
    }
}
