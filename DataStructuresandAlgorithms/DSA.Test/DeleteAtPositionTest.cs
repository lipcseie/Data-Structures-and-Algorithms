using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeleteAtPosition;

namespace DSA.Test
{
    public class DeleteAtPositionTest
    {
        [Fact]
        [Trait("Category", "DeleteAtPositionTest")]
        public void DeleteAtPosition_ShouldRemoveElement()
        {
            // Arrange
            int[] originalArray = { 1, 2, 3 };
            int position = 1;
            int[] expcetedArray = { 1, 3 };

            // Act
            int[] result = Program.DeleteAtPosition(originalArray, position);


            // Assert

            Assert.Equal(expcetedArray, result);
            Assert.Equal(originalArray.Length - 1, result.Length);
        }

        [Fact]
        [Trait("Category", "DeleteAtPositionTest")]
        public void DeleteAtPosition_EmptyArray_ShouldThrowException()
        {
            // Arrange
            int[] originalArray = { };
            int position = 1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.DeleteAtPosition(originalArray, position));
        }

        [Fact]
        [Trait("Category", "DeleteAtPositionTest")]
        public void DeleteAtPosition_NullArray_ShouldThrowExeption()
        {
            // Arrange
            int[] originalArray = null;
            int position = 1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.DeleteAtPosition(originalArray, position));
        }

        [Fact]
        [Trait("Category", "DeleteAtPositionTest")]
        public void DeleteAtPosition_PositionNegativeInteger_ShouldThrowExeption()
        {
            // Arrange
            int[] originalArray = { 1, 2, 3 };
            int position = -1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.DeleteAtPosition(originalArray, position));
        }

        [Fact]
        [Trait("Category", "DeleteAtPositionTest")]
        public void DeleteAtPosition_ArrayLenghtBiggerOrEqualWithPosition_ShouldThrowExeption()
        {
            // Arrange
            int[] originalArray = { 1, 2, 3 };
            int position = 9;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.DeleteAtPosition(originalArray, position));
        }
    }
}
