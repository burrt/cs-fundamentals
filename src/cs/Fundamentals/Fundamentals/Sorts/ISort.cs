using System;

namespace Fundamentals.Sorts
{
    public interface ISort<T> where T : IComparable, IComparable<T>
    {
        /// <summary>
        /// Sort the array in-place.
        /// </summary>
        /// <param name="array">Array to sort.</param>
        public void Sort(T[] array);
    }
}
