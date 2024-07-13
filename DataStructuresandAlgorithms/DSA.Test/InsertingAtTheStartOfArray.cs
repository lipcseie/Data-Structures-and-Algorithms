using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsertingAtTheStartOfArray;

namespace DSA.Test
{
    public class InsertingAtTheStartOfArray
    {
        [Fact]
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

    }
}
