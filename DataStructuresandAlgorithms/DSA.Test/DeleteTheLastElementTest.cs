using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeleteTheLastElement;

namespace DSA.Test
{
    public class DeleteTheLastElementTest
    {
        [Fact]
        [Trait("Category", "DeleteTheLastElementTest")]
        public void DeleteTheLastElement_ShouldRemoveElement()
        {
            // Arrange
            int[] originalArray = { 1, 2, 3 };
            int[] expcetedArray = { 1, 2};

            // Act
            int[] result = Program.DeleteTheLastElement(originalArray);


            // Assert

            Assert.Equal(expcetedArray, result);
            Assert.Equal(originalArray.Length - 1, result.Length);
        }


        [Fact]
        [Trait("Category", "DeleteTheLastElementTest")]
        public void DeleteTheLastElement_EmptyArray_ShouldThrowException()
        {
            // Arrange
            int[] originalArray = { };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.DeleteTheLastElement(originalArray));
        }

        [Fact]
        [Trait("Category", "DeleteTheLastElementTest")]
        public void DeleteTheLastElement_NullArray_ShouldThrowExeption()
        {
            // Arrange
            int[] originalArray = null;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.DeleteTheLastElement(originalArray));
        }
    }
}
