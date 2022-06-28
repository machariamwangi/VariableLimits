using System;

namespace VariableLimits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TYPE                                      MIN                           MAX");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Integral Types:");
            Console.WriteLine($"sbyte          {sbyte.MinValue,30}{sbyte.MaxValue,30}"); 
            Console.WriteLine($"byte           {byte.MinValue,30}{byte.MaxValue,30}");
            Console.WriteLine($"short          {short.MinValue,30}{short.MaxValue,30}");
            Console.WriteLine($"ushort         {ushort.MinValue,30}{ushort.MaxValue,30}");
            Console.WriteLine($"int            {int.MinValue,30}{int.MaxValue,30}");
            Console.WriteLine($"uint           {uint.MinValue,30}{uint.MaxValue,30}");
            Console.WriteLine($"long           {long.MinValue,30}{long.MaxValue,30}");
            Console.WriteLine($"ulong          {ulong.MinValue,30}{ulong.MaxValue,30}");
            Console.WriteLine("");
            Console.WriteLine("Floating Point Types:");
            Console.WriteLine($"float          {float.MinValue,30}{float.MaxValue,30}");
            Console.WriteLine($"double         {double.MinValue,30}{double.MaxValue,30}");
            Console.WriteLine($"decimal        {decimal.MinValue,30}{decimal.MaxValue,30}");
            Console.WriteLine("");
            Console.WriteLine("DateTime Types:");
            Console.WriteLine($"DateTime       {DateTime.MinValue,30}{DateTime.MaxValue,30}");
            Console.WriteLine($"DateTimeOffset {DateTimeOffset.MinValue,30}{DateTimeOffset.MaxValue,30}");
        }
    }
}
