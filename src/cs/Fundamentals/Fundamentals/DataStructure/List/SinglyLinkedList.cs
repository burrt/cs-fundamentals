using System;

namespace Fundamentals.DataStructure.List
{
    public class SinglyLinkedList<T> : ISinglyLinkedList<T>
    {
        private int listSize;
        private ISinglyLinkedListNode<T> Head { get; set; }
        private ISinglyLinkedListNode<T> Tail { get; set; }

        public SinglyLinkedList()
        {
            listSize = 0;
        }

        public SinglyLinkedList(T value)
        {
            var node = new SinglyLinkedListNode<T>(value);

            Head = node;
            Tail = node;
            listSize = 1;
        }

        public int Size() => listSize;

        public bool IsEmpty()
        {
            if (listSize < 0)
            {
                throw new InvalidOperationException("List size is less than zero.");
            }

            return listSize == 0;
        }

        public T GetFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty.");
            }

            return Head.Value;
        }

        public T GetLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty.");
            }

            return Tail.Value;
        }

        public void AddLast(T value)
        {
            var node = new SinglyLinkedListNode<T>(value);

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

            listSize++;
        }

        public void AddFirst(T value)
        {
            var node = new SinglyLinkedListNode<T>(value);
            
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

            listSize++;
        }

        public T RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty.");
            }

            var node = Head;
            Head = Head.Next;
            listSize--;

            return node.Value;
        }

        public T RemoveLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty.");
            }

            var node = Tail;
            Tail = Tail.Next;
            listSize--;

            return node.Value;
        }
    }
}
