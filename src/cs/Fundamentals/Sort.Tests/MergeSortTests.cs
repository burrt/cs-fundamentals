using Fundamentals.Sorts;
using System;
using Xunit;

namespace Sort.Tests
{
    public class MergeSortTests
    {
        private ISort<int> MergeSort { get; }

        public MergeSortTests()
        {
            MergeSort = new MergeSort<int>();
        }

        [Fact]
        public void Sort_WithNullArray_ThrowsException()
        {
            Assert.ThrowsAny<Exception>(() => MergeSort.Sort(null));
        }

        [Fact]
        public void Sort_WithEmptyArray_IsSuccessful()
        {
            MergeSort.Sort(Array.Empty<int>());
        }

        [Fact]
        public void Sort_WithSingleElementArray_IsSuccessful()
        {
            MergeSort.Sort(new[] { 0 });
        }

        [Fact]
        public void Sort_WithValidArray_IsSuccessful()
        {
            var unsortedArray = new[] { 5, 4, 3, 2, 1 };

            MergeSort.Sort(unsortedArray);

            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, unsortedArray);
        }
    }
}
