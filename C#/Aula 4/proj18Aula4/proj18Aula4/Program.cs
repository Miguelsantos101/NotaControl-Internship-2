using System;
using System.Globalization;

namespace proj18Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int n, homens = 0, mulheres = 0;
            double alturaMaior = 0, alturaMenor = 0, mediaMulheres = 0;

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(" ");

                if (i == 0)
                {
                    alturaMenor = Convert.ToDouble(entrada[0]);
                    alturaMaior = Convert.ToDouble(entrada[0]);
                }
                else
                {
                    if (Convert.ToDouble(entrada[0]) > alturaMaior)
                    {
                        alturaMaior = Convert.ToDouble(entrada[0]);
                    }

                    if (Convert.ToDouble(entrada[0]) < alturaMenor)
                    {
                        alturaMenor = Convert.ToDouble(entrada[0]);
                    }
                }


                if (Convert.ToChar(entrada[1]) == 'M')
                {
                    homens++;
                }
                else
                {
                    mediaMulheres += Convert.ToDouble(entrada[0]);
                    mulheres++;
                }
            }

            Console.WriteLine($"Menor altura = {alturaMenor:F2}");
            Console.WriteLine($"Maior altura = {alturaMaior:F2}");
            Console.WriteLine($"Media das alturas das mulheres = {mediaMulheres / mulheres:F2}");
            Console.WriteLine($"Numero de homens = {homens}");

        }
    }
}
