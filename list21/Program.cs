using System;

namespace List
{
    class Program
    {
        private static void Main(string[] args)
        {
            var list = new List();
            Console.WriteLine(list.IsEmpty);
            list.Append(0, "programm");
            list.Append(1, "array");
            list.Printing();
            list.Append(5, "list");
            list.Remove(1);
            list.Printing();
            list[0] = "value";
            Console.WriteLine(list[0]);
            list.Append(1, "list");
            Console.WriteLine(list.Size);
            Console.WriteLine(list.IsEmpty);
        }
    }
}