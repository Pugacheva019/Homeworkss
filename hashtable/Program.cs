using System;
namespace hashtable
{
    public class Program
    {
        public static IHashFunction Selection(int choice)
        {
            if (choice == 1)
            {
                return new IHashFunction1();
            }
            else if (choice == 2)
            {
                return new IHashFunction2();
            }
            else
            {
                return null;
            }
        }
        public static void Main()
        {
            Console.WriteLine("Select type of hash-function:1,2");
            int choice = int.Parse(Console.ReadLine());
            var hashFunction = Selection(choice);
            if (hashFunction == null)
            {
                Console.WriteLine("Hash function was not selected!");
                return;
            }
            var hashTable = new HashTable(5, hashFunction);
            hashTable.Append(1, "lemon");
            hashTable.Append(7, "melon");
            hashTable.Append(4, "orange");
            hashTable.Append(10, "tomato");
            hashTable.Delete(4);
            Console.WriteLine(hashTable.Find(7)); 
            Console.WriteLine(hashTable.Find(14));
            hashTable.Printing();
        }

    }
}
