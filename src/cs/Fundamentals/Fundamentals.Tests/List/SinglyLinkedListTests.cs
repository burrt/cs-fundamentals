using System;
using Fundamentals.DataStructure.List;
using Xunit;

namespace Fundamentals.Tests.List
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void Size_ForEmptyList_ReturnsZero()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.Equal(0, singlyLinkedList.Size());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void Size_ForNonEmptyList_ReturnsGreaterThanZero(int nodesToAdd)
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            for (var i = 0; i < nodesToAdd; i++)
            {
                singlyLinkedList.AddLast(i);
            }

            Assert.Equal(nodesToAdd, singlyLinkedList.Size());
        }

        [Fact]
        public void IsEmpty_ForEmptyList_ReturnsTrue()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.True(singlyLinkedList.IsEmpty());
        }

        [Fact]
        public void IsEmpty_ForNonEmptyList_ReturnsFalse()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(1);

            Assert.False(singlyLinkedList.IsEmpty());
        }

        [Fact]
        public void GetFirst_ForEmptyList_ThrowsException()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.ThrowsAny<Exception>(() => singlyLinkedList.GetFirst());
        }

        [Fact]
        public void GetFirst_ForNonEmptyList_Success()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(1);

            var resultValue = singlyLinkedList.GetFirst();

            Assert.Equal(1, resultValue);
        }

        [Fact]
        public void GetLast_ForEmptyList_ThrowsException()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.ThrowsAny<Exception>(() => singlyLinkedList.GetLast());
        }

        [Fact]
        public void GetLast_ForNonEmptyList_Success()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(1);

            var resultValue = singlyLinkedList.GetLast();

            Assert.Equal(1, resultValue);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void AddLast_ToEmptyList_Success(int nodeValue)
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            singlyLinkedList.AddLast(nodeValue);

            Assert.Equal(nodeValue, singlyLinkedList.GetLast());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void AddLast_ToNonEmptyList_Success(int nodeValue)
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(-1);

            singlyLinkedList.AddLast(nodeValue);

            Assert.Equal(-1, singlyLinkedList.GetFirst());
            Assert.Equal(nodeValue, singlyLinkedList.GetLast());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void AddFirst_ToEmptyList_Success(int nodeValue)
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            singlyLinkedList.AddFirst(nodeValue);

            Assert.Equal(nodeValue, singlyLinkedList.GetFirst());
            Assert.Equal(nodeValue, singlyLinkedList.GetLast());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void AddFirst_ToNonEmptyList_Success(int nodeValue)
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(-1);

            singlyLinkedList.AddFirst(nodeValue);

            Assert.Equal(nodeValue, singlyLinkedList.GetFirst());
            Assert.Equal(-1, singlyLinkedList.GetLast());
        }

        [Fact]
        public void RemoveFirst_ForEmptyList_ThrowsException()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.ThrowsAny<Exception>(() => singlyLinkedList.RemoveFirst());
        }

        [Fact]
        public void RemoveFirst_ForNonEmptyList_Success()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            singlyLinkedList.AddFirst(1);

            var value = singlyLinkedList.RemoveFirst();

            Assert.Equal(1, value);
            Assert.True(singlyLinkedList.IsEmpty());
        }

        [Fact]
        public void RemoveLast_ForEmptyList_ThrowsException()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.ThrowsAny<Exception>(() => singlyLinkedList.RemoveLast());
        }

        [Fact]
        public void RemoveLast_ForNonEmptyList_Success()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            singlyLinkedList.AddFirst(1);

            var itemValue = singlyLinkedList.RemoveLast();

            Assert.Equal(1, itemValue);
            Assert.True(singlyLinkedList.IsEmpty());
        }
    }
}
