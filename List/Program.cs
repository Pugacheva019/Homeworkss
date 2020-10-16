using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List();
            Console.WriteLine(list.IsEmpty);
            list.Append(0, "programm");
            list.Append(1, "array");
            list.Print();
            list.Append(1, "list");
            list.Remove(1);
            list.Print();
            list[0] = "value";
            Console.WriteLine(list[0]);
            list.Append(1, "list");
            Console.WriteLine(list.Size);
            Console.WriteLine(list.IsEmpty);
        }
    }
}
