using System;

namespace Hashtable
{
    /// <summary>
    /// Class for second hashfunction.
    /// </summary>
    public class HashFunction2 : IHashFunction
    {
        /// <summary>
        ///Implementation of hashfunction.
        /// </summary>
        /// <param name="key">Unique key of element.</param>
        /// <param name="size">Size of hashtable.</param>
        /// <returns>Integer address of element to search in hashtable.</returns>
        public int HashFunction(int key, int size)
        {
            return key % size;
        }
    }
}
