using InsertElementAtPosition;

namespace DSA.Test
{
    public class InsertElementAtPosition
    {
        [Fact]
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
    }
}
