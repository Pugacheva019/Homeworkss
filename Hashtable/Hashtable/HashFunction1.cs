using System;

namespace Hashtable
{
    /// <summary>
    /// Class of first hashfunction.
    /// </summary>
    public class HashFunction1 : IHashFunction
    {
        /// <summary>
        ///Implementation of multiplicative hash function.
        /// </summary>
        /// <param name="key">Unique key of element.</param>
        /// <param name="size">Size of table.</param>
        /// <returns>Integer address of element to search in hashtable.</returns>
        public int HashFunction(int key, int length)
        {
            return (int)Math.Floor(length * (key * 0.73 - Math.Floor(key * 0.73)));
        }
    }
}
