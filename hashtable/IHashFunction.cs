using System;

namespace hashtable
{
    /// <summary>
    /// Class for hash function.
    /// </summary>
    public class IHashFunction
    {
        public int HashFunction(int key, int size)
        {
            return key % size;
        }
    }
}
