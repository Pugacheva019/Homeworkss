using System;
namespace Hashtable
{
    public class Program
    {
        static void Main()
        {
            var hashFunction = new IHashFunction(); 
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
