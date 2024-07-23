﻿using ShellSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Test
{
    public class ShellShortTest
    {
        [Fact]
        [Trait("Category", "ShellSortTests")]
        public void ShellSort_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { 5, 2, 9, 1, 5, 6 };
            int[] expectedOutput = { 1, 2, 5, 5, 6, 9 };

            // Act
            ShellShortClass.ShellShort(input);

            // Assert
            Assert.Equal(expectedOutput, input);
        }
    }
}