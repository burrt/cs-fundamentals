using System;
using Fundamentals.Core.Guards;
using Fundamentals.Sorts;

namespace Sort
{
    public class SelectionSort<T> : ISort<T> where T : IComparable, IComparable<T>
    {
        public void Sort(T[] array)
        {
            Guard.IsNotNull(array, nameof(array));

            if (array.Length == 0 || array.Length == 1)
            {
                return;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                // track the min value of the RHS of the array
                var minIndex = i;
                var min = array[i];

                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k].CompareTo(min) < 0)
                    {
                        minIndex = k;
                        min = array[k];
                    }
                }

                if (minIndex != i)
                {
                    Swapper<T>.Swap(array, i, minIndex);
                }
            }
        }
    }
}
