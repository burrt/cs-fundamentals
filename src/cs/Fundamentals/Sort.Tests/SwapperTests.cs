using System;
using Xunit;

namespace Sort.Tests
{
    public class SwapperTests
    {
        [Fact]
        public void Swap_WithNullArray_ThrowsException()
        {
            Assert.ThrowsAny<Exception>(() => Swapper<int>.Swap(null, 1, 1));
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(1, -1)]
        [InlineData(-1, -1)]
        public void Swap_WithNegativeIndexes_ThrowsException(int x, int y)
        {
            Assert.ThrowsAny<Exception>(() => Swapper<int>.Swap(new int[1], x, y));
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(0, 1)]
        [InlineData(2, 0)]
        [InlineData(0, 2)]
        [InlineData(2, 2)]
        public void Swap_WithIndexesOutOfArrayBounds_ThrowsException(int x, int y)
        {
            Assert.ThrowsAny<Exception>(() => Swapper<int>.Swap(new int[1], x, y));
        }

        [Fact]
        public void Swap_WithValidArray_IsSuccessful()
        {
            var a = new [] { 1, 2 };

            Swapper<int>.Swap(a, 0, 1);

            Assert.Equal(2, a[0]);
            Assert.Equal(1, a[1]);
        }
    }
}
