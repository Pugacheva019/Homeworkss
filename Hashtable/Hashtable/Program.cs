using System;

namespace Hashtable
{
    public class Program
    {
        /// <summary>
        /// Method of the selection of hashfunction.
        /// </summary>
        public static IHashFunction SelectionOfHashFunction(int selection)
        {
            if (selection == 1)
            {
                return new HashFunction1();
            }
            else if (selection == 2)
            {
                return new HashFunction2();
            }
            else
            {
                Console.WriteLine("Mistake!");
                return null;
            }
        }

        static void Main()
        {
            Console.WriteLine("Select type of hash-function: one or two");
            int selection = int.Parse(Console.ReadLine());
            var hashFunction = SelectionOfHashFunction(selection);
            if (hashFunction == null)
            {
                Console.WriteLine("Hash-function was not selected!");
                return;
            }
            var hashTable = new HashTable(5, hashFunction);
            hashTable.Append(1, "lemon");
            hashTable.Append(7, "melon");
            hashTable.Append(4, "orange");
            hashTable.Append(10, "tomato");
            hashTable.Delete(4);
            Console.WriteLine(hashTable.Find(3));
            Console.WriteLine(hashTable.Find(14));
            hashTable.Printing();
        }
    }
}