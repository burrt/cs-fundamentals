using System;

namespace Fundamentals.DataStructure.Stack
{
    public class BasicStack<T> : IBasicStack<T>
    {
        private int stackSize;
        private IStackNode<T> Top { get; set; }

        public BasicStack()
        {
            stackSize = 0;
        }

        public BasicStack(T value)
        {
            var item = new StackNode<T>(value);
            Top = item;
            stackSize = 1;
        }

        public int Size()
        {
            if (stackSize < 0)
            {
                throw new InvalidOperationException("Stack size is less than zero.");
            }

            return stackSize;
        }

        public bool IsEmpty()
        {
            if (stackSize < 0)
            {
                throw new InvalidOperationException("Stack size is less than zero.");
            }

            return stackSize == 0;
        }

        public void Push(T value)
        {
            var item = new StackNode<T>(value)
            {
                Next = Top
            };

            Top = item;
            stackSize++;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var item = Top;
            Top = Top.Next;
            stackSize--;

            return item.Value;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return Top.Value;
        }
    }
}
