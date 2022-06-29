using System;

namespace MoreLogicFlows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var value in array)
            {
                switch (value)
                {
                    case 1:
                        Console.WriteLine($"Found 1");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine($"Found 2, 3 or 4 {value}");
                        break;
                    default:
                        Console.WriteLine($"Found something else {value}");
                        break;
                }
            }
        }
    }
}
