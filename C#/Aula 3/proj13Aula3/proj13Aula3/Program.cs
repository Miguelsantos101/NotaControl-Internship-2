using System;
using System.Globalization;

namespace proj13Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double antigoSalario, novoSalario, reajuste, percentual;

            antigoSalario = Convert.ToDouble(Console.ReadLine());

            if (antigoSalario <= 400)
            {
                novoSalario = antigoSalario * 1.15;
                reajuste = novoSalario - antigoSalario;
                percentual = 15;
            }
            else if (antigoSalario <= 800)
            {
                novoSalario = antigoSalario * 1.12;
                reajuste = novoSalario - antigoSalario;
                percentual = 12;
            }
            else if (antigoSalario <= 1200)
            {
                novoSalario = antigoSalario * 1.10;
                reajuste = novoSalario - antigoSalario;
                percentual = 10;
            }
            else if (antigoSalario <= 2000)
            {
                novoSalario = antigoSalario * 1.07;
                reajuste = novoSalario - antigoSalario;
                percentual = 7;
            }
            else
            {
                novoSalario = antigoSalario * 1.04;
                reajuste = novoSalario - antigoSalario;
                percentual = 4;
            }

            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
            Console.WriteLine($"Em percentual: {percentual}%");
        }
    }
}
