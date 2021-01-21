using Fundamentals.Sorts;
using System;
using Xunit;

namespace Sort.Tests
{
    public class SelectionSortTests
    {
        private ISort<int> SelectionSort { get; }

        public SelectionSortTests()
        {
            SelectionSort = new SelectionSort<int>();
        }

        [Fact]
        public void Sort_WithNullArray_ThrowsException()
        {
            Assert.ThrowsAny<Exception>(() => SelectionSort.Sort(null));
        }

        [Fact]
        public void Sort_WithEmptyArray_IsSuccessful()
        {
            SelectionSort.Sort(Array.Empty<int>());
        }

        [Fact]
        public void Sort_WithSingleElementArray_IsSuccessful()
        {
            SelectionSort.Sort(new[] { 0 });
        }

        [Fact]
        public void Sort_WithValidArray_IsSuccessful()
        {
            var unsortedArray = new[] { 5, 4, 3, 2, 1 };

            SelectionSort.Sort(unsortedArray);

            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, unsortedArray);
        }
    }
}
