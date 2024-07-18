using InsertElementAtPosition;

namespace DSA.Test
{
    public class InsertElementAtPositionTest
    {
        [Fact]
        [Trait("Category", "InsertElementAtPositionTests")]
        public void InsertElementAtPosition_ShouldInsertElement()
        {
            // Arrange
            int[] originalArray = { 1, 2, 3 };
            int newElement = 9;
            int position = 1;
            int[] expcetedArray = { 1, 9, 2, 3 };

            // Act
            int[] result = Program.InsertElementAtPosition(originalArray, newElement, position);
     

            // Assert

            Assert.Equal(expcetedArray, result);
            Assert.Equal(originalArray.Length + 1, result.Length);
        }

        [Fact]
        [Trait("Category", "InsertElementAtPositionTests")]
        public void InsertElementAtPosition_EmptyArray_ShouldThrowException()
        {
            // Arrange
            int[] originalArray = { };
            int newElement = 9;
            int position = 1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.InsertElementAtPosition(originalArray, newElement, position));
        }

        [Fact]
        [Trait("Category", "InsertElementAtPositionTests")]
        public void InsertElementAtPosition_NullArray_ShouldThrowExeption()
        {
            // Arrange
            int[] originalArray = null;
            int newElement = 9;
            int position = 1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.InsertElementAtPosition(originalArray, newElement, position));
        }


        [Fact]
        [Trait("Category", "InsertElementAtPositionTests")]
        public void InsertElementAtPosition_PositionNegativeInteger_ShouldThrowExeption()
        {
            // Arrange
            int[] originalArray = { 1, 2, 3 };
            int position = -1;
            int newElememnt = 9;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.InsertElementAtPosition(originalArray,newElememnt, position));
        }

        [Fact]
        [Trait("Category", "InsertElementAtPositionTests")]
        public void InsertElementAtPosition_ArrayLenghtBiggerOrEqualWithPosition_ShouldThrowExeption()
        {
            // Arrange
            int[] originalArray = { 1, 2, 3 };
            int position = 9;
            int newElememnt = 9;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.InsertElementAtPosition(originalArray,newElememnt, position));
        }
    }
}
