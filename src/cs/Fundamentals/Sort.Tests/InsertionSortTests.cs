using Fundamentals.Sorts;
using System;
using Xunit;

namespace Sort.Tests
{
    public class InsertionSortTests
    {
        private ISort<int> InsertionSort { get; }

        public InsertionSortTests()
        {
            InsertionSort = new InsertionSort<int>();
        }

        [Fact]
        public void Sort_WithNullArray_ThrowsException()
        {
            Assert.ThrowsAny<Exception>(() => InsertionSort.Sort(null));
        }

        [Fact]
        public void Sort_WithEmptyArray_IsSuccessful()
        {
            InsertionSort.Sort(Array.Empty<int>());
        }

        [Fact]
        public void Sort_WithSingleElementArray_IsSuccessful()
        {
            InsertionSort.Sort(new [] { 0 });
        }

        [Fact]
        public void Sort_WithValidArray_IsSuccessful()
        {
            var unsortedArray = new[] {5, 4, 3, 2, 1};

            InsertionSort.Sort(unsortedArray);

            Assert.Equal(new [] { 1, 2, 3, 4, 5 }, unsortedArray);
        }
    }
}
