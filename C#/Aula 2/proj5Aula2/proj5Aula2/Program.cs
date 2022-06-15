using System;
using System.Globalization;

namespace proj5Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double A, B, media;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());

            media = ((A * 3.5) + (B * 7.5)) / (3.5 + 7.5);

            Console.WriteLine($"MEDIA = {media:F5}");
        }
    }
}
