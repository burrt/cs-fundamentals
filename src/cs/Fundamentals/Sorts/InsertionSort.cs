using System;

namespace Sort
{
    public class InsertionSort
    {
        public void Sort(int[] a)
        {
            for (var i = 1; i < a.Length; i++)
            {
                for (var j = i; j> 0; j--)
                {
                    if (a[j] < a[j - 1])
                    {
                        Swap(a, j, j - 1);
                    }
                }
            }
        }

        private void Swap(int[] a, int x, int y)
        {
            var temp = a[x];
            a[x] = a[y];
            a[y] = temp;
        }
    }
}
