using System;
using DataStructure.Stack;
using Fundamentals.DataStructure.Stack;
using Xunit;

namespace DataStructure.Tests.Stack
{
    public class BasicStackTests
    {
        [Fact]
        public void Size_ForEmptyStack_ReturnsZero()
        {
            IBasicStack<int> stack = new BasicStack<int>();

            Assert.Equal(0, stack.Size());
        }

        [Fact]
        public void Size_ForNonEmptyStack_ReturnsOne()
        {
            IBasicStack<int> stack = new BasicStack<int>();
            for (var i = 0; i < 3; i++)
            {
                stack.Push(new StackNode<int>(i));
            }

            Assert.Equal(3, stack.Size());
        }

        [Fact]
        public void Size_ForNonEmptyStackAfterPushAndPop_Success()
        {
            IBasicStack<int> stack = new BasicStack<int>();
            stack.Push(new StackNode<int>(1));
            stack.Push(new StackNode<int>(2));
            stack.Push(new StackNode<int>(3));
            stack.Pop();

            Assert.Equal(2, stack.Size());
        }

        [Fact]
        public void IsEmpty_ForEmptyStack_ReturnsTrue()
        {
            IBasicStack<int> stack = new BasicStack<int>();

            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void IsEmpty_ForNonEmptyStack_ReturnsFalse()
        {
            IBasicStack<int> stack = new BasicStack<int>();
            for (var i = 0; i < 3; i++)
            {
                stack.Push(new StackNode<int>(i));
            }

            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void Push_WithNullNode_ThrowsException()
        {
            IBasicStack<int> stack = new BasicStack<int>();

            Assert.ThrowsAny<Exception>(() => stack.Push(null));
        }

        [Fact]
        public void Push_WithValidItem_Success()
        {
            IBasicStack<int> stack = new BasicStack<int>();

            stack.Push(new StackNode<int>(1));

            Assert.Equal(1, stack.Size());
        }

        [Fact]
        public void Peek_ForEmptyStack_ReturnsNull()
        {
            IBasicStack<int> stack = new BasicStack<int>();

            Assert.Null(stack.Peek());
        }

        [Fact]
        public void Peek_ForNonEmptyStack_Success()
        {
            IBasicStack<int> stack = new BasicStack<int>(new StackNode<int>(1));

            var item = stack.Peek();

            Assert.Equal(1, item.Value);
        }

        [Fact]
        public void Pop_ForEmptyStack_ThrowsException()
        {
            IBasicStack<int> stack = new BasicStack<int>();

            Assert.ThrowsAny<Exception>(() => stack.Pop());
        }

        [Fact]
        public void Pop_ForNonEmptyStack_Success()
        {
            IBasicStack<int> stack = new BasicStack<int>();
            for (var i = 0; i < 3; i++)
            {
                stack.Push(new StackNode<int>(i));
            }

            var item = stack.Pop();

            Assert.Equal(2, item.Value);
        }
    }
}
