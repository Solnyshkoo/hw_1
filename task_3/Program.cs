using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double I, P;
            Console.Write("Напряжение U: ");
            double U = double.Parse(Console.ReadLine());
            Console.Write("Напряжение R: ");
            int R = int.Parse(Console.ReadLine());
            I = U / R;
            P = Math.Pow(U, 2) / R;
            Console.WriteLine(I);
            Console.WriteLine(P);
        }
    }
}
