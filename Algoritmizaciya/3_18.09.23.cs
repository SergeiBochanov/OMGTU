using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = Convert.ToInt32(Console.ReadLine());
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{(a + b) / 2 - Math.Abs(a - b) / 2} {(a + b) / 2 + Math.Abs(a - b) / 2}");
        }
    }
}
