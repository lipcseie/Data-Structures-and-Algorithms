using SelectionSort;
using ShellSort;

namespace DSA.Test
{
    public class ShellShortTest
    {
        [Fact]
        [Trait("Category", "ShellSortTests")]
        public void ShellSort_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { 5, 2, 9, 1, 5, 6 };
            int[] expectedOutput = { 1, 2, 5, 5, 6, 9 };

            // Act
            ShellShortClass.ShellShort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "ShellSortTests")]
        public void ShellSort_EmptyArray_DoesNotChange()
        {
            //Arrange
            int[] input = new int[0];
            int[] expectedOutput = new int[0];

            // Act
            ShellShortClass.ShellShort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "ShellSortTests")]
        public void ShellSort_SingleElementArray_DoesNotChange()
        {
            // Arrange
            int[] input = { 42 };
            int[] expectedOutput = { 42 };

            // Act
            ShellShortClass.ShellShort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }

        [Fact]
        [Trait("Category", "ShellSortTests")]
        public void ShellSort_AlreadySortedArray_DoesNotChange()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            ShellShortClass.ShellShort(input);

            // Assert
            Assert.Equal(expected, input);
        }
    }
}
