using MergeSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Test
{
    public class MergSortTest
    {
        [Fact]
        [Trait("Category", "MergSortTest")]
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
        [Trait("Category", "MergSortTest")]
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
    }
}
