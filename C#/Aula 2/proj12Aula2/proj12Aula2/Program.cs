using System;
using System.Globalization;

namespace proj12Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double media;
            string[] vet = Console.ReadLine().Split(" ");
            string[] vet2 = Console.ReadLine().Split(" ");

            media = (Int32.Parse(vet[1]) + Int32.Parse(vet2[1])) / 2.0;

            Console.WriteLine($"A idade média de {vet[0]} e {vet2[0]} é de {media:F1} anos");
        }
    }
}
