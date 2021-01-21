namespace Fundamentals.DataStructure.Stack
{
    public class StackNode<T> : IStackNode<T>
    {
        public T Value { get; set; }
        public IStackNode<T> Next { get; set; }

        public StackNode(T value)
        {
            Value = value;
        }
    }
}
