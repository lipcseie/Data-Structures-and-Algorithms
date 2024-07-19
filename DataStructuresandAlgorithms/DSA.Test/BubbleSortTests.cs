using BubbleSort;

namespace DSA.Test
{
    public class BubbleSortTests
    {
        [Fact]
        [Trait("Category", "BubbleSortTests")]
        public void BubbleSort_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { 5, 2, 9, 1, 5, 6 };
            int[] expectedOutput = { 1, 2, 5, 5, 6, 9 };

            // Act
            BubbleSortClass.BubbleSort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "BubbleSortTests")]
        public void BubbleSort_EmptyArray_DoesNotChange()
        {
            //Arrange
            int[] input = new int[0];
            int[] expectedOutput = new int[0];

            // Act
            BubbleSortClass.BubbleSort(input);

            // Assert
            Assert.Equal(expectedOutput,input);
        }
    }
}
