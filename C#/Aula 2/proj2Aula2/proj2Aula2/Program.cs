using System;
using System.Globalization;

namespace proj2Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double largura, comprimento, valorMetroQuadrado, area, preco;

            largura = Convert.ToDouble(Console.ReadLine());
            comprimento = Convert.ToDouble(Console.ReadLine());
            valorMetroQuadrado = Convert.ToDouble(Console.ReadLine());

            area = largura * comprimento;
            preco = valorMetroQuadrado * area;

            Console.WriteLine($"AREA = {area:F2}");
            Console.WriteLine($"PRECO = {preco:F2}");
        }
    }
}
