using System;

namespace proj1Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }
        }
    }
}
