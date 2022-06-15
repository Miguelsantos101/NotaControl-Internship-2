using System;
using System.Globalization;

namespace proj3Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double basee, altura, area, perimetro, diagonal;
            basee = Convert.ToDouble(Console.ReadLine());
            altura = Convert.ToDouble(Console.ReadLine());

            area = basee * altura;
            perimetro = 2 * (basee + altura);
            diagonal = Math.Sqrt(Math.Pow(basee, 2.0) + Math.Pow(altura, 2.0));
            Console.WriteLine($"AREA = {area:F4}");
            Console.WriteLine($"PERIMETRO = {perimetro:F4}");
            Console.WriteLine($"DIAGONAL = {diagonal:F4}");
        }
    }
}
