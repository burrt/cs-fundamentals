namespace Fundamentals.DataStructure.List
{
    public interface ISinglyLinkedList<T>
    {
        public bool IsEmpty();
        public int Size();
        public T GetFirst();
        public T GetLast();
        public void AddLast(T value);
        public void AddFirst(T value);
        public T RemoveFirst();
        public T RemoveLast();
    }
}
