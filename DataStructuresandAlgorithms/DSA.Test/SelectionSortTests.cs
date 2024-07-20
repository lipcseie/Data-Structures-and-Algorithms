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
    }
}
