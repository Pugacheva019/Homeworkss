namespace hashtable
{
    /// <summary>
    /// Class for hash function.
    /// </summary>
    public class IHashFunction1 : IHashFunction
    {
        /// <summary>
        /// Method of hash function.
        /// </summary>
        /// <param name="key"> Key of element.</param>
        /// <param name="size">Size of hash table.</param>
        /// <returns> value of hash-function.</returns>
        public int HashFunction(int key, int size)
        {
            return key % size;
        }
    }
}