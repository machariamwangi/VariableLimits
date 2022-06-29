using System;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "Hello World";
            string s2 = s1.Substring(1, 2);
            Console.WriteLine($"s1: {s1}, s2: {s2}");

            string[] strings = { "Abc", "cde", "efg", "ghi", "ijk", "lmn" };

            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine($"Row {i + 1}: {strings[i]}");
            }

            for (int i = strings.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Row {i + 1}: {strings[i]}");
            }

            string[,] solid = {
                                    { "*", "*", "*",  "*", "*"},
                                    { "*", "*", "*",  "*", "*"},
                                    { "*", "*", "*",  "*", "*"},
                                    { "*", "*", "*",  "*", "*"},
                                    { "*", "*", "*",  "*", "*"}
                              };
            string[,] thex = {
                                    { "*", "", "",  "", "*"},
                                    { "", "*", "",  "*", ""},
                                    { "", "", "*",  "", ""},
                                    { "", "*", "",  "*", ""},
                                    { "*", "", "",  "", "*"}
                              };

            for (var i=0; i< solid.GetLength(0); i++)
            {
                for (var j=0; j<solid.GetLength(1); j++)
                {
                    Console.Write(solid[i, j]);
                }
                Console.WriteLine();
            }

            for (var i = 0; i < thex.GetLength(0); i++)
            {
                for (var j = 0; j < thex.GetLength(1); j++)
                {
                    Console.Write(thex[i, j]);
                }
                Console.WriteLine();
            }

            string[,] result = new string[5, 5];
            for (var i = 0; i < thex.GetLength(0); i++)
            {
                for (var j = 0; j < thex.GetLength(1); j++)
                {
                    if (solid[i, j] != thex[i, j]) result[i, j] = "*";
                    else result[i, j] = "";
                }
                Console.WriteLine();
            }

            for (var i = 0; i < result.GetLength(0); i++)
            {
                for (var j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
