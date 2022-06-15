using System;

namespace proj28Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            string vencedor;
            int fla, flu, opcao = 1, qtdJogos = 0, vFla = 0, vFlu = 0, empate = 0;
            string[] numeros = new string[1];

            while (opcao == 1)
            {
                numeros = (Console.ReadLine().Split(" "));

                fla = Convert.ToInt32(numeros[0]);
                flu = Convert.ToInt32(numeros[1]);

                if (fla > flu)
                {
                    vFla++;
                }
                else if (fla < flu)
                {
                    vFlu++;
                }
                else
                {
                    empate++;
                }
                qtdJogos++;

                Console.WriteLine("Novo FlaFlu (1-sim 2-nao)");
                opcao = Convert.ToInt32(Console.ReadLine());
            }

            if (opcao == 2)
            {
                Console.WriteLine($"{qtdJogos} FlaFlus");
                Console.WriteLine($"Flamengo: {vFla}");
                Console.WriteLine($"Fluminense: {vFlu}");
                Console.WriteLine($"Empates: {empate}");

                if (vFla > vFlu)
                {
                    vencedor = "Flamengo";
                    Console.WriteLine($"{vencedor} venceu mais");
                }
                else if (vFla < vFlu)
                {
                    vencedor = "Fluminense";
                    Console.WriteLine($"{vencedor} venceu mais");
                }
                else
                {
                    Console.WriteLine("Nao houve vencedor");
                }

            }
        }
    }
}
