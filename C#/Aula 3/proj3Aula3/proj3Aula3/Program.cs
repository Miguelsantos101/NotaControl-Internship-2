using System;
using System.Globalization;

namespace proj3Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int idade;
            bool estudante;

            Console.WriteLine("Qual a idade? ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("E estudante? Sim (true), Nao (false) ");
            estudante = Convert.ToBoolean(Console.ReadLine());

            if (idade >= 65 || estudante)
            {
                Console.WriteLine("Valor do ingresso: R$15,00.");
            }
            else
            {
                Console.WriteLine("Valor do ingresso: R$30,00.");
            }

        }
    }
}
