using System;
using System.Globalization;

namespace proj3Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double celsius, fahrenheit;
            string opcao = "s";


            while (opcao != "n")
            {
                Console.Write("Digite a temperatura em Celsius: ");
                celsius = Convert.ToDouble(Console.ReadLine());

                fahrenheit = (9.0 / 5) * celsius + 32;
                Console.WriteLine($"Equivalente em Fahrenheit: {fahrenheit:F1}");

                Console.Write("Deseja repetir (s/n)? ");
                opcao = Console.ReadLine();
            }
        }
    }
}
