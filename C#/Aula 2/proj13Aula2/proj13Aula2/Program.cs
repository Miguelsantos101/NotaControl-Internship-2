using System;
using System.Globalization;

namespace proj13Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string[] nomeCompleto = new string[1];
            Console.WriteLine("Entre com seu nome completo: ");
            nomeCompleto = Console.ReadLine().Split(" ");

            int qtdQuartos;
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            qtdQuartos = Convert.ToInt32(Console.ReadLine());

            double precoProduto;
            Console.WriteLine("Entre com o preco de um produto: ");
            precoProduto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha): ");
            string[] vetor = new string[2];
            vetor = Console.ReadLine().Split(" ");

            Console.WriteLine($"{nomeCompleto[0]} {nomeCompleto[1]}");
            Console.WriteLine(qtdQuartos);
            Console.WriteLine($"{precoProduto:F2}");
            Console.WriteLine($"{vetor[0]}\n{vetor[1]}\n{vetor[2]}");
        }
    }
}
