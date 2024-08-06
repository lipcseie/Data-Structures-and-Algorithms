using LinearSearch;
using MergeSort;

namespace DSA.Test
{
    public class LinearSearchTest
    {
        [Fact]
        [Trait("Category", "LinearSearchTest")]
        public void LinearSearch_FindsTargetValue_ReturnsIndex()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            int target = 3;
            int expectedIndex = 2;

            // Act
            int resultIndex = Program.LinearSearch(numbers, target);

            // Assert
            Assert.Equal(expectedIndex, resultIndex);

        }

        [Fact]
        [Trait("Category", "LinearSearchTest")]
        public void LinearSearch_LargeArray_FindsTargetValue_ReturnsInde()
        {
            // Arrange
            int[] numbers = Enumerable.Range(1, 1000).Reverse().ToArray();
            int target = 1;
            int expectedIndex = 999;


            // Act
            int resultIndex = Program.LinearSearch(numbers, target);

            // Assert
            Assert.Equal(expectedIndex, resultIndex);
        }

        [Fact]
        [Trait("Category", "LinearSearchTest")]
        public void LinearSearch_TargetNotInArray_ReturnsNegativeOne()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            int target = 10;
            int expectedIndex = -1;

            // Act
            int resultIndex = Program.LinearSearch(numbers, target);

            // Assert
            Assert.Equal(expectedIndex, resultIndex);
        }

        [Fact]
        [Trait("Category", "LinearSearchTest")]
        public void LinearSearch_ArrayIsEmpty_ThrowsArgumentException()
        {
            // Arrange
            int[] numbers = { };
            int target = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.LinearSearch(numbers, target));
        }

        [Fact]
        [Trait("Category", "LinearSearchTest")]
        public void LinearSearch_TargetNegative_ThrowsArgumentException()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            int target = -1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.LinearSearch(numbers, target));
        }
    }
}
