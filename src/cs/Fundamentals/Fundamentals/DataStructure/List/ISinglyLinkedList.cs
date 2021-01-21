namespace Fundamentals.DataStructure.List
{
    public interface ISinglyLinkedList<T>
    {
        public ISinglyLinkedListNode<T> Head { get; set; }
        public ISinglyLinkedListNode<T> Append(ISinglyLinkedListNode<T> node);
    }
}
