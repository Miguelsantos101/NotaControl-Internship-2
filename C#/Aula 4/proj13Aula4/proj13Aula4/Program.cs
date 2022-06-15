using System;
using System.Globalization;

namespace proj13Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int t;

            t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int anos = 0, PA, PB;
                double G1, G2;
                string[] entrada = Console.ReadLine().Split(" ");

                PA = Convert.ToInt32(entrada[0]);
                PB = Convert.ToInt32(entrada[1]);
                G1 = Convert.ToDouble(entrada[2]);
                G2 = Convert.ToDouble(entrada[3]);

                while (PA <= PB && anos <= 100)
                {
                    PA += (int)((PA * G1) / 100);
                    PB += (int)((PB * G2) / 100);
                    anos++;

                }

                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo");
                }
                else
                {
                    Console.WriteLine($"{anos} anos.");
                }
            }



        }
    }
}
