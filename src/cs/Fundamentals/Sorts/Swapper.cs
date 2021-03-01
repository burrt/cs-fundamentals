using System;
using Fundamentals.Core.Guards;

namespace Sort
{
    public static class Swapper<T>
    {
        public static void Swap(T[] a, int x, int y)
        {
            Guard.IsNotNull(a, nameof(a));
            Guard.IsNotLessThanZero(x, nameof(x));
            Guard.IsNotLessThanZero(y, nameof(y));

            if (x >= a.Length || y >= a.Length)
            {
                throw new ArgumentException("Indexes are out of the array's bounds.");
            }

            var temp = a[x];
            a[x] = a[y];
            a[y] = temp;
        }
    }
}
