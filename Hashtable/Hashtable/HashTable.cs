using System;
using ListProgram;

namespace Hashtable
{
    /// <summary>
    /// Class for hash table.
    /// </summary>
    public class HashTable
    {
        private readonly List[] buckets;

        /// <summary>
        /// Size of the hash table.
        /// </summary>
        private readonly int size;

        /// <summary>
        /// Count of elements in hash table.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// current hash function.
        /// </summary>
        private readonly IHashFunction HashFunction;

        /// <summary>
        /// creates the hash table with a specific size.
        /// </summary>
        /// <param name="size">Size of table.</param>
        public HashTable(int size, IHashFunction HashFunction)
        {
            if (HashFunction == null)
            {
                Console.WriteLine("Hash function was not put!");
                return;
            }
            buckets = new List[size];
            this.HashFunction = HashFunction;
            this.size = size;
        }
        /// <summary>
        /// Method for printing Elements.
        /// </summary>
        public void Printing()
        {
            for (int i = 0; i < size; i++)
            {
                if (buckets[i] != null)
                {
                    buckets[i].Printing();
                }
            }
        }

        /// <summary>
        /// Method for getting list by position in array of lists.
        /// </summary>
        /// <param name="position">Position of list in the array.</param>
        /// <returns></returns>
        private List HashList(int position)
        {
            List Hashlist = buckets[position];
            if (Hashlist == null)
            {
                Hashlist = new List();
                buckets[position] = Hashlist;
            }
            return Hashlist;
        }

        /// <summary>
        /// Method for adding elements.
        /// </summary>
        /// <param name="key"> key of element.</param>
        /// <param name="data">Element value.</param>
        public void Append(int key, string data)
        {
            var list = HashList(Math.Abs(HashFunction.HashFunction(key, size)) % size);
            list.Append(key, list.Size, data);
            ++Count;
        }

        /// <summary>
        /// Method for removing element from the table.
        /// </summary>
        /// <param name="key">key of element.</param>
        public void Delete(int key)
        {
            HashList(Math.Abs(HashFunction.HashFunction(key, size)) % size).RemoveByKey(key);
            --Count;
        }

        /// <summary>
        /// Hash table is empty or not.
        /// </summary>
        public bool IsEmpty => size == 0;

        // <summary>
        /// Method for finding elements in the hash table.
        /// </summary>
        /// <param name="key"> key of element.</param>
        public bool Find(int key) => HashList(Math.Abs(HashFunction.HashFunction(key, size)) % size).Finding(key);
    }
}