using System;
using Fundamentals.Core.Guards;
using Fundamentals.Sorts;

namespace Sorts
{
    public class InsertionSort<T> : ISort<T> where T : IComparable, IComparable<T>
    {
        public void Sort(T[] array)
        {
            Guard.IsNotNull(array, nameof(array));

            if (array.Length == 0 || array.Length == 1)
            {
                return;
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int k = i; k > 0; k--)
                {
                    if (array[k].CompareTo(array[k - 1]) < 0)
                    {
                        Swap(array, k, k - 1);
                    }
                }
            }
        }

        private void Swap(T[] a, int x, int y)
        {
            var temp = a[x];
            a[x] = a[y];
            a[y] = temp;
        }
    }
}
