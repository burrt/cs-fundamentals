using DataStructure.List;
using System;
using Xunit;

namespace DataStructure.Tests.List
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void Append_WithNullNode_ThrowsException()
        {
            var singlyLinkedList = new SinglyLinkedList<int>();

            Assert.ThrowsAny<Exception>(() => singlyLinkedList.Append(null));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void Append_WithValidNodeToEmptyList_Success(int nodeValue)
        {
            var singlyLinkedList = new SinglyLinkedList<int>();
            var node = new SinglyLinkedListNode<int>(nodeValue);

            var n = singlyLinkedList.Append(node);

            Assert.Equal(nodeValue, n.Value);
            Assert.Equal(nodeValue, singlyLinkedList.Head.Value);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void Append_WithValidNodeToNonEmptyList_Success(int nodeValue)
        {
            var singlyLinkedList = new SinglyLinkedList<int>(new SinglyLinkedListNode<int>(-1));
            var node = new SinglyLinkedListNode<int>(nodeValue);

            var n = singlyLinkedList.Append(node);

            Assert.Equal(nodeValue, n.Value);
            Assert.Equal(-1, singlyLinkedList.Head.Value);
            Assert.Equal(nodeValue, singlyLinkedList.Head.Next.Value);
        }
    }
}
