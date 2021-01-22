namespace Fundamentals.DataStructure.List
{
    public interface ISinglyLinkedList<T>
    {
        public bool IsEmpty();
        public int Size();
        public ISinglyLinkedListNode<T> GetFirst();
        public ISinglyLinkedListNode<T> GetLast();
        public ISinglyLinkedListNode<T> AddLast(ISinglyLinkedListNode<T> node);
        public ISinglyLinkedListNode<T> AddFirst(ISinglyLinkedListNode<T> node);

    }
}
