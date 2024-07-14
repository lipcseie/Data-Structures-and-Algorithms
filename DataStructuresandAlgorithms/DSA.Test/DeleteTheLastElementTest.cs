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
        [Trait("Category", "ArrayTests")]
        public void InsertElementAtPosition_ShouldInsertElement()
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
    }
}
