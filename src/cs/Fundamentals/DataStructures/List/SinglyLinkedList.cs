using System;
using Fundamentals.Core;
using Fundamentals.DataStructure.List;

namespace DataStructure.List
{
    public class SinglyLinkedList<T> : ISinglyLinkedList<T>
    {
        private ISinglyLinkedListNode<T> Head { get; set; }
        private ISinglyLinkedListNode<T> Tail { get; set; }
        private int ListSize;

        public SinglyLinkedList()
        {
            ListSize = 0;
        }

        public SinglyLinkedList(ISinglyLinkedListNode<T> node)
        {
            Guard.IsNotNull(node, nameof(node));

            Head = node;
            Tail = node;
            ListSize++;
        }

        public int Size() => ListSize;

        public bool IsEmpty()
        {
            if (ListSize < 0)
            {
                throw new InvalidOperationException("List size is less than zero.");
            }

            return ListSize == 0;
        }

        public ISinglyLinkedListNode<T> GetFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty.");
            }

            return Head;
        }

        public ISinglyLinkedListNode<T> GetLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty.");
            }

            return Tail;
        }

        public ISinglyLinkedListNode<T> AddLast(ISinglyLinkedListNode<T> node)
        {
            Guard.IsNotNull(node, nameof(node));

            if (IsEmpty())
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }

            ListSize++;

            return node;
        }

        public ISinglyLinkedListNode<T> AddFirst(ISinglyLinkedListNode<T> node)
        {
            Guard.IsNotNull(node, nameof(node));
            
            if (IsEmpty())
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }

            ListSize++;

            return node;
        }
    }
}
