using System;
using System.Globalization;

namespace proj4Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double raio, n = 3.14159, area;
            raio = Convert.ToDouble(Console.ReadLine());

            area = n * Math.Pow(raio, 2.0);

            Console.WriteLine($"A={area:F4}");
        }
    }
}
