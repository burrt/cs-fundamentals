using Fundamentals.DataStructure.Stack;
using System;
using Fundamentals.Core;

namespace DataStructure.Stack
{
    public class BasicStack<T> : IBasicStack<T>
    {
        private IStackNode<T> Top { get; set; }
        private int stackSize;

        public BasicStack()
        {
            stackSize = 0;
        }

        public BasicStack(IStackNode<T> item)
        {
            Guard.IsNotNull(item, nameof(item));

            Top = item;
            stackSize = 1;
        }

        public int Size()
        {
            if (stackSize < 0)
            {
                throw new InvalidOperationException("stackSize is less than zero.");
            }

            return stackSize;
        }

        public bool IsEmpty()
        {
            if (stackSize < 0)
            {
                throw new InvalidOperationException("stackSize is less than zero.");
            }

            return stackSize == 0;
        }

        public void Push(IStackNode<T> item)
        {
            Guard.IsNotNull(item, nameof(item));

            item.Next = Top;
            Top = item;
            stackSize++;
        }

        public IStackNode<T> Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var item = Top;
            Top = Top.Next;
            stackSize--;

            return item;
        }

        public IStackNode<T> Peek()
        {
            return Top;
        }
    }
}
