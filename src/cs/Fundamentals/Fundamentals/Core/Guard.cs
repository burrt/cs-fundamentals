using System;

namespace Fundamentals.Core
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
    }
}
