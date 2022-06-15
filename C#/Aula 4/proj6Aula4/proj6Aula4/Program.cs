using System;
using System.Globalization;

namespace proj6Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int n;
            double x1, x2, x3, mediaP;

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] numeros = new string[2];
                numeros = Console.ReadLine().Split(" ");

                x1 = Convert.ToDouble(numeros[0]);
                x2 = Convert.ToDouble(numeros[1]);
                x3 = Convert.ToDouble(numeros[2]);

                mediaP = (x1 * 2 + x2 * 3 + x3 * 5) / 10;
                Console.WriteLine($"{mediaP:F1}");

            }
        }
    }
}
