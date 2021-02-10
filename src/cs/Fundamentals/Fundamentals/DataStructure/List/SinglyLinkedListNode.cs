namespace Fundamentals.DataStructure.List
{
    public class SinglyLinkedListNode<T> : ISinglyLinkedListNode<T>
    {
        public T Value { get; }
        public ISinglyLinkedListNode<T> Next { get; set; }


        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }
    }
}
