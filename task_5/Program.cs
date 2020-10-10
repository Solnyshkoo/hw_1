using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите катет: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите катет: ");
            int b = int.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"Гипотенуза: {c}");
        }
    }
}
