namespace Fundamentals.DataStructure.List
{
    public interface ISinglyLinkedListNode<T>
    {
        public T Value { get; }
        public ISinglyLinkedListNode<T> Next { get; set; }
    }
}
