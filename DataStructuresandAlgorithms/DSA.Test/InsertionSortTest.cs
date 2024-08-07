﻿using InsertionSort;
using SelectionSort;

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

        [Fact]
        [Trait("Category", "InsertionSortTest")]
        public void InsertionSort_AlreadySortedArray_DoesNotChange()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            InsertionSortClass.InsertionSort(input);

            // Assert
            Assert.Equal(expected, input);
        }

        [Fact]
        [Trait("Category", "InsertionSortTest")]
        public void InsertionSort_LargeArray_SortsCorretly()
        {
            // Arrange
            int[] input = Enumerable.Range(1, 1000).Reverse().ToArray();
            int[] expetedOutput = Enumerable.Range(1, 1000).ToArray();

            // Act
            InsertionSortClass.InsertionSort(input);

            // Assert
            Assert.Equal(expetedOutput, input);
        }

        [Fact]
        [Trait("Category", "InsertionSortTest")]
        public void InsertionSort_ArrayWithNegativeNumbers_SortsCorrectly()
        {
            // Arrange
            int[] input = { -3, -1, -2, 0, 2, 1 };
            int[] expetedOutput = { -3, -2, -1, 0, 1, 2 };

            // Act
            InsertionSortClass.InsertionSort(input);

            // Assert
            Assert.Equal(expetedOutput, input);
        }
    }
}
