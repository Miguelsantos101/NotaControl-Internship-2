using System;

namespace proj17Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, anoNascimento, anoIngresso, idade, tempoTrabalho;

            codigo = Convert.ToInt32(Console.ReadLine());
            anoNascimento = Convert.ToInt32(Console.ReadLine());
            anoIngresso = Convert.ToInt32(Console.ReadLine());

            idade = 2022 - anoNascimento;
            tempoTrabalho = 2022 - anoIngresso;

            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Tempo de servico: {tempoTrabalho}");

            if (idade >= 65 || tempoTrabalho >= 30 || (idade >= 60 && tempoTrabalho >= 25))
            {
                Console.WriteLine($"Requerer aposentadoria");
            }
            else
            {
                Console.WriteLine($"Nao requerer");
            }
        }
    }
}
