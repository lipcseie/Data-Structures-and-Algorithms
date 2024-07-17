using DeleteTheFirstElement;

namespace DSA.Test
{
    public class DeleteTheFirstElementTest
    {
        [Fact]
        [Trait("Category", "DeleteTheFirstElementTest")]
        public void DeleteTheFirstElement_ShouldRemoveElement()
        {
            // Arrange
            int[] originalArray = { 1, 2, 3 };
            int[] expcetedArray = { 2 ,3};

            // Act
            int[] result = Program.DeleteTheFirstElement(originalArray);


            // Assert

            Assert.Equal(expcetedArray, result);
            Assert.Equal(originalArray.Length - 1, result.Length);
        }
    }
}
