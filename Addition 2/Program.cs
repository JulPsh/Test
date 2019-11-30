using System;

namespace Addition_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число 1:");
            int x =int.Parse(Console.ReadLine());
            Console.Write("Введите число 2:");
            int y = int.Parse(Console.ReadLine());
            int z = x + y;
            Console.WriteLine($"{z}");
            Console.ReadKey();
        }
    }
}