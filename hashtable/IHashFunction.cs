using System;

namespace hashtable
{
    /// <summary>
    /// Class for hash function.
    /// </summary>
    /// <param name="key">Unique key of element.</param>
    /// <param name="size">Size of hash table.</param>
    public interface IHashFunction
    {
        int HashFunction(int key, int size);
    }
}
