using System;
using System.Globalization;

namespace proj8Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int n, quantidade, total = 0, totalC = 0, totalR = 0, totalS = 0;
            char tipo;
            double coelhoP, ratosP, saposP;

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entrada = new string[1];
                entrada = Console.ReadLine().Split(" ");

                quantidade = Convert.ToInt32(entrada[0]);
                tipo = Convert.ToChar(entrada[1]);

                if (tipo == 'C')
                {
                    totalC += quantidade;
                }
                else if (tipo == 'R')
                {
                    totalR += quantidade;
                }
                else if (tipo == 'S')
                {
                    totalS += quantidade;
                }
                total += quantidade;
            }
            coelhoP = 100.0 * totalC / total;
            ratosP = 100.0 * totalR / total;
            saposP = 100.0 * totalS / total;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {totalC}");
            Console.WriteLine($"Total de ratos: {totalR}");
            Console.WriteLine($"Total de sapos: {totalS}");
            Console.WriteLine($"Percentual de coelhos: {coelhoP:F2}%");
            Console.WriteLine($"Percentual de ratos: {ratosP:F2}%");
            Console.WriteLine($"Percentual de sapos: {saposP:F2}%");
        }
    }
}
