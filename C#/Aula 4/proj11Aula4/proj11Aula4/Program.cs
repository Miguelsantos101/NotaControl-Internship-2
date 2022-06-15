using System;

namespace proj11Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n, total = 0;

            string[] numeros;
            numeros = Console.ReadLine().Split(" ");

            a = Convert.ToInt32(numeros[0]);
            n = Convert.ToInt32(numeros[numeros.Length - 1]);

            for (int i = 0; i < n; i++)
            {
                total += a + i;
            }

            Console.WriteLine(total);
        }
    }
}
