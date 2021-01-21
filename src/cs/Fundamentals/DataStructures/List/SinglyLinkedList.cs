using Fundamentals.Core;
using Fundamentals.DataStructure.List;

namespace DataStructure.List
{
    public class SinglyLinkedList<T> : ISinglyLinkedList<T>
    {
        public ISinglyLinkedListNode<T> Head { get; set; }

        public SinglyLinkedList()
        {
            Head = null;
        }

        public SinglyLinkedList(ISinglyLinkedListNode<T> head)
        {
            Head = head ?? null;
        }

        public ISinglyLinkedListNode<T> Append(ISinglyLinkedListNode<T> node)
        {
            Guard.IsNotNull(node, nameof(node));

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Head.Next = node;
            }

            return node;
        }
    }
}
