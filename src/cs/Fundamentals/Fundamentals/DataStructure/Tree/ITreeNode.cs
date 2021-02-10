using Fundamentals.DataStructure.List;

namespace Fundamentals.DataStructure.Tree
{
    public interface ITreeNode<T>
    {
        public T Value { get; set; }
        public bool Visited { get; set; }
        public ISinglyLinkedList<ITreeNode<T>> Children { get; }
    }
}
