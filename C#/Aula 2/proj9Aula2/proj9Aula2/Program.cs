using System;
using System.Globalization;

namespace proj9Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int tempoViagem, velocidadeMedia;
            double litros;
            tempoViagem = Convert.ToInt32(Console.ReadLine());
            velocidadeMedia = Convert.ToInt32(Console.ReadLine());

            litros = (tempoViagem * velocidadeMedia) / 12.0;

            Console.WriteLine($"{litros:F3}");
        }
    }
}
