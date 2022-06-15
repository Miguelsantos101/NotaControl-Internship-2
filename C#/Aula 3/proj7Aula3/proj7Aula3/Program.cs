using System;
using System.Globalization;

namespace proj7Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double nota1, nota2, notaFinal;

            nota1 = Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());

            notaFinal = nota1 + nota2;

            Console.WriteLine($"NOTA FINAL = {notaFinal:F1}");
            if (notaFinal <= 60)
            {
                Console.WriteLine("REPROVADO");
            }

        }
    }
}
