using System;


namespace MovetoFront
{
    class Program
    {
        public static void Main()
        {
            var Value = new MoveToFront();
            var List = Value.StringCoding("melon");
            foreach (var Mtf in List)
            {
                Console.Write( Mtf + " ");
            }
        }
    }
}