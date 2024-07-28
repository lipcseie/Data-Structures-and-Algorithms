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
    }
}
