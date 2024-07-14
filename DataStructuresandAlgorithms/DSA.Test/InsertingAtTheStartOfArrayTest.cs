using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsertingAtTheStartOfArray;

namespace DSA.Test
{
    public class InsertingAtTheStartOfArrayTest
    {
        [Fact]
        [Trait("Category", "InsertingAtTheStartOfArrayTest")]
        public void InsertingAtTheStartOfArray_ShouldInsertElement()
        {
            // Arrange
            int[] originalArray = { 1, 2, 3 };
            int newElement = 9;
            int[] expcetedArray = { 9, 1, 2, 3 };

            // Act
            int[] result = Program.InsertingAtTheStartOfArray(originalArray, newElement);

            // Assert

            Assert.Equal(expcetedArray, result);
            Assert.Equal(originalArray.Length + 1, result.Length);
        }

        [Fact]
        [Trait("Category", "InsertingAtTheStartOfArrayTest")]
        public void InsertingAtTheStartOfArray_EmptyArray_ShouldThrowException()
        {
            // Arrange
            int[] originalArray = { };
            int newElement = 9;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.InsertingAtTheStartOfArray(originalArray, newElement));
        }

        [Fact]
        [Trait("Category", "InsertingAtTheStartOfArrayTest")]
        public void InsertingAtTheStartOfArray_NullArray_ShouldThrowException()
        {
            // Arrange
            int[] originalArray = null;
            int newElement = 9;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.InsertingAtTheStartOfArray(originalArray, newElement));
        }
    }
}
