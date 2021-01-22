using DataStructure.List;
using System;
using Fundamentals.DataStructure.List;
using Xunit;

namespace DataStructure.Tests.List
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void Size_WithEmptyList_ReturnsZero()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.Equal(0, singlyLinkedList.Size());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void Size_WithNonEmptyList_ReturnsGreaterThanZero(int nodesToAdd)
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            for (var i = 0; i < nodesToAdd; i++)
            {
                singlyLinkedList.AddLast(new SinglyLinkedListNode<int>(i));
            }

            Assert.Equal(nodesToAdd, singlyLinkedList.Size());
        }

        [Fact]
        public void IsEmpty_WithEmptyList_ReturnsTrue()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            
            Assert.True(singlyLinkedList.IsEmpty());
        }

        [Fact]
        public void IsEmpty_WithNonEmptyList_ReturnsFalse()
        {
             ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(new SinglyLinkedListNode<int>(1));

            Assert.False(singlyLinkedList.IsEmpty());
        }

        [Fact]
        public void GetFirst_WithEmptyList_ThrowsException()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.ThrowsAny<Exception>(() => singlyLinkedList.GetFirst());
        }

        [Fact]
        public void GetFirst_WithNonEmptyList_Success()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(new SinglyLinkedListNode<int>(1));

            var resultNode = singlyLinkedList.GetFirst();

            Assert.Equal(1, resultNode.Value);
        }

        [Fact]
        public void GetLast_WithEmptyList_ThrowsException()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.ThrowsAny<Exception>(() => singlyLinkedList.GetLast());
        }

        [Fact]
        public void GetLast_WithNonEmptyList_Success()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(new SinglyLinkedListNode<int>(1));

            var resultNode = singlyLinkedList.GetLast();

            Assert.Equal(1, resultNode.Value);
        }

        [Fact]
        public void AddLast_WithNullNode_ThrowsException()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.ThrowsAny<Exception>(() => singlyLinkedList.AddLast(null));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void AddLast_WithValidNodeToEmptyList_Success(int nodeValue)
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            var node = new SinglyLinkedListNode<int>(nodeValue);

            var n = singlyLinkedList.AddLast(node);

            Assert.Equal(nodeValue, n.Value);
            Assert.Equal(nodeValue, singlyLinkedList.GetFirst().Value);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void AddLast_WithValidNodeToNonEmptyList_Success(int nodeValue)
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(new SinglyLinkedListNode<int>(-1));
            var node = new SinglyLinkedListNode<int>(nodeValue);

            var n = singlyLinkedList.AddLast(node);

            Assert.Equal(nodeValue, n.Value);
            Assert.Equal(-1, singlyLinkedList.GetFirst().Value);
            Assert.Equal(nodeValue, singlyLinkedList.GetLast().Value);
        }

        [Fact]
        public void AddFirst_WithNullNode_ThrowsException()
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.ThrowsAny<Exception>(() => singlyLinkedList.AddFirst(null));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void AddFirst_WithValidNodeToEmptyList_Success(int nodeValue)
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            var node = new SinglyLinkedListNode<int>(nodeValue);

            var n = singlyLinkedList.AddFirst(node);

            Assert.Equal(nodeValue, n.Value);
            Assert.Equal(nodeValue, singlyLinkedList.GetFirst().Value);
            Assert.Equal(nodeValue, singlyLinkedList.GetLast().Value);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void AddFirst_WithValidNodeToNonEmptyList_Success(int nodeValue)
        {
            ISinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(new SinglyLinkedListNode<int>(-1));
            var node = new SinglyLinkedListNode<int>(nodeValue);

            var n = singlyLinkedList.AddFirst(node);

            Assert.Equal(nodeValue, n.Value);
            Assert.Equal(nodeValue, singlyLinkedList.GetFirst().Value);
            Assert.Equal(-1, singlyLinkedList.GetLast().Value);
        }

    }
}
