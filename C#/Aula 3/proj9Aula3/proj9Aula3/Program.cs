using System;
using System.Globalization;

namespace proj9Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int minutos;
            double total;

            minutos = Convert.ToInt32(Console.ReadLine());

            if (minutos <= 100)
            {
                total = 50;
            }
            else
            {
                total = 50 + ((minutos - 100) * 2);
            }

            Console.WriteLine($"Valor a pagar: R${total:F2}");
        }
    }
}
