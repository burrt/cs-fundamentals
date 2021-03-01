namespace Fundamentals.DataStructure.Stack
{
    public interface IStackNode<T>
    {
        public T Value { get; set; }
        public IStackNode<T> Next { get; set; }
    }
}
