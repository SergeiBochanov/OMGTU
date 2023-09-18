using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            if (k/3600 > 10)
            {
                Console.Write($"{k / 3600}:");
            } else
            {
                Console.Write($"0{k / 3600}:");
            }
            if ((k%3600)/60 > 10)
            {
                Console.Write($"{(k % 3600) / 60}:");
            } else
            {
                Console.Write($"0{(k % 3600) / 60}:");
            }
            if ((k % 3600) % 60 > 10)
            {
                Console.Write($"{(k % 3600) % 60}");
            }
            else
            {
                Console.Write($"0{k % 3600 % 60}");
            }
        }
    }
}
