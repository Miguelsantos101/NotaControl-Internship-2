using System;
using System.Globalization;

namespace proj16Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int n;
            double mediaAltura = 0, idadeP = 0, pessoasCom16 = 0;

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(" ");
                mediaAltura += Convert.ToDouble(entrada[2]);
                if (Convert.ToInt32(entrada[1]) < 16)
                {
                    pessoasCom16++;
                }
            }

            Console.WriteLine($"Altura media: {mediaAltura / n:F2}");
            Console.WriteLine($"Pessoas com menos de 16 anos: {idadeP = pessoasCom16 * 100 / n :F1}%");
        }
    }
}
