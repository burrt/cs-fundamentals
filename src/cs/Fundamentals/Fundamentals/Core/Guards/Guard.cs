using System;

namespace Fundamentals.Core.Guards
{
    public static class Guard
    {
        public static void IsNotNull(object obj, string objName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(objName);
            }
        }

        public static void IsNotLessThanZero(int x, string xName)
        {
            if (x < 0)
            {
                throw new ArgumentException($"{xName} is less than zero.");
            }
        }
    }
}
