using System;
using Fundamentals.DataStructure.Stack;
using Xunit;

namespace Fundamentals.Tests.Stack
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
                stack.Push(i);
            }

            Assert.Equal(3, stack.Size());
        }

        [Fact]
        public void Size_ForNonEmptyStackAfterPushAndPop_Success()
        {
            IBasicStack<int> stack = new BasicStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
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
                stack.Push(i);
            }

            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void Push_WithValidValue_Success()
        {
            IBasicStack<int> stack = new BasicStack<int>();

            stack.Push(1);

            Assert.Equal(1, stack.Size());
        }

        [Fact]
        public void Peek_ForEmptyStack_ThrowsException()
        {
            IBasicStack<int> stack = new BasicStack<int>();

            Assert.ThrowsAny<Exception>(() => stack.Peek());
        }

        [Fact]
        public void Peek_ForNonEmptyStack_Success()
        {
            IBasicStack<int> stack = new BasicStack<int>(1);

            var itemValue = stack.Peek();

            Assert.Equal(1, itemValue);
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
                stack.Push(i);
            }

            var itemValue = stack.Pop();

            Assert.Equal(2, itemValue);
        }
    }
}
