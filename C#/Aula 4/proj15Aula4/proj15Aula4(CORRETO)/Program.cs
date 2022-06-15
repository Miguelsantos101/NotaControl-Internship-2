using System;
using System.Globalization;

namespace proj15Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int n;
            double soma = 0, media = 0;

            n = Convert.ToInt32(Console.ReadLine());

            string[] entrada = Console.ReadLine().Split(" ");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{entrada[i]} ");
                soma += Convert.ToDouble(entrada[i]);
            }

            media = soma / n;
            Console.WriteLine("");
            Console.WriteLine($"{soma:F2}");
            Console.WriteLine($"{media:F2}");
        }
    }
}
