using System;
using System.Globalization;

namespace proj7Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int A, B, C, D, diferenca;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert.ToInt32(Console.ReadLine());

            diferenca = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
