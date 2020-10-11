using System;

namespace Hashtable
{
    /// <summary>
    /// Method of hashfunctions.
    /// </summary>
    public interface IHashFunction
    {
        /// <summary>
        /// Calculation of hash-function.
        /// </summary>
        /// <param name="value">String which hashcode is calculated</param>
        /// <param name="length">Length of hashtable</param>
        /// <returns>The value of hashfunction</returns>
        int HashFunction(int key, int length);
    }
}