namespace Fundamentals.DataStructure.Stack
{
    public interface IBasicStack<T>
    {
        public int Size();
        public bool IsEmpty();
        public void Push(T value);
        public T Pop();
        public T Peek();
    }
}
