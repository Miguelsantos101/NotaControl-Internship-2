using System;
using System.Globalization;

namespace proj26Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double nota1, nota2, media;

            nota1 = Convert.ToDouble(Console.ReadLine());
            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("nota invalida");
                nota1 = Convert.ToDouble(Console.ReadLine());
                
            }

            nota2 = Convert.ToDouble(Console.ReadLine());
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                nota2 = Convert.ToDouble(Console.ReadLine());
            }

            media = (nota1 + nota2) / 2;

            Console.WriteLine($"media = {media:F2}");
        }
    }
}
