using System;

namespace Aleksandar_Shahanski_9e_N1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    Console.WriteLine(int.MinValue);
                    Console.WriteLine( int.MaxValue);
                    break;
                case "uint":
                    Console.WriteLine(uint.MaxValue);
                    Console.WriteLine(uint.MinValue);
                    break;
                case "long":
                    Console.WriteLine(long.MaxValue);
                    Console.WriteLine(long.MinValue);
                    break;
                case "byte":
                    Console.WriteLine(byte.MaxValue);
                    Console.WriteLine(byte.MinValue);
                    break;
                case "sbyte":
                    Console.WriteLine(sbyte.MaxValue);
                    Console.WriteLine(sbyte.MinValue);
                    break;
            }
        }
    }
}
