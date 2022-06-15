using System;

namespace proj4Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, soma = 0;
            int[,] A;
            N = int.Parse(Console.ReadLine());
            A = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i < j)
                    {
                        soma += A[i, j];
                    }
                }
            }

            Console.WriteLine(soma);
        }
    }
}
