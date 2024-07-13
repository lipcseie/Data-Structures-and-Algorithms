using InsertingAtTheEndOfArray;

namespace DSA.Test
{
    public class InsertingAtTheEndOfArrayTets
    {
        [Fact]
        [Trait("Category", "ArrayTests")]
        public void InsertingAtTheEndOfArray_ShouldInsertElement()

        {
            // Arrange
            int[] originalArray = {1, 2, 3};
            int newElement = 9;
            int[] expcetedArray = {1, 2, 3, 9};

            // Act 
            int[] result = Program.InsertingAtTheEndOfArray(originalArray, newElement);

            // Assert

            Assert.Equal(expcetedArray, result);
            Assert.Equal(originalArray.Length + 1, result.Length);
        }

    }
}