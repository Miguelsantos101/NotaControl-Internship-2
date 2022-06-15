using System;

namespace proj7Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maior = 0, posicao = 0;

            for (int i = 1; i <= 5; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    maior = n;
                    posicao = i;
                }
                else
                {
                    if (n > maior)
                    {
                        maior = n;
                        posicao = i;
                    }
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
