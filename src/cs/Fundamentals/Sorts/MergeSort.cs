using Fundamentals.Core.Guards;
using Fundamentals.Sorts;
using System;

namespace Sort
{
    public class MergeSort<T> : ISort<T> where T : IComparable, IComparable<T>
    {
        public void Sort(T[] array)
        {
            Guard.IsNotNull(array, nameof(array));

            if (array.Length == 0 || array.Length == 1)
            {
                return;
            }

            // The helper array is used for merging the sorted numbers
            var helperArray = new T[array.Length];

            MergeSortRecursive(array, helperArray, 0, array.Length - 1);
        }

        /// <summary>
        /// Merge sort using the helper array.
        /// </summary>
        /// <param name="array">Array to sort.</param>
        /// <param name="helperArray">Helper array.</param>
        /// <param name="low">Low index.</param>
        /// <param name="high">High index.</param>
        private static void MergeSortRecursive(T[] array, T[] helperArray, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            var mid = (low + high) / 2;

            // Sort left half of array
            MergeSortRecursive(array, helperArray, low, mid);

            // Sort right half of array
            MergeSortRecursive(array, helperArray, mid + 1, high);

            Merge(array, helperArray, mid, low, high);
        }

        /// <summary>
        /// Merges the "left" and "right" half of the array.
        /// </summary>
        /// <param name="array">Array under sort.</param>
        /// <param name="helperArray">Helper array.</param>
        /// <param name="mid">Mid index.</param>
        /// <param name="low">Low index.</param>
        /// <param name="high">High index.</param>
        private static void Merge(T[] array, T[] helperArray, int mid, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            // Copy array into the helper
            for (int i = low; i <= high; i++)
            {
                helperArray[i] = array[i];
            }

            int leftIndex = low;
            int rightIndex = mid + 1;

            // Iterate over both the "left" and "right" half of the helper array and
            // insert the values in order into the array
            int index = low;
            while (leftIndex <= mid && rightIndex <= high)
            {
                if (helperArray[leftIndex].CompareTo(helperArray[rightIndex]) < 0)
                {
                    array[index++] = helperArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[index++] = helperArray[rightIndex];
                    rightIndex++;
                }
            }

            // The "right" half of the array will essentially be "in-order"
            // So we only need to worry about copying the left hand side
            int remainder = mid - leftIndex + 1;
            for (int i = 0; i < remainder; i++)
            {
                array[index++] = helperArray[leftIndex++];
            }
        }
    }
}
