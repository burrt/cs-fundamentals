namespace Fundamentals.DataStructure.Stack
{
    public interface IBasicStack<T>
    {
        public int Size();
        public bool IsEmpty();
        public void Push(IStackNode<T> item);
        public IStackNode<T> Pop();
        public IStackNode<T> Peek();
    }
}
