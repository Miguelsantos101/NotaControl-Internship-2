using System;
using System.Globalization;

namespace proj6Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double A, B, C, media;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());

            media = ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5);

            Console.WriteLine($"MEDIA = {media:F1}");
        }
    }
}
