using System;

namespace proj2Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
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

            for (int i = 0; i < N; i++)
            {
                int totalLinha = 0;
                for (int j = 0; j < N; j++)
                {
                    totalLinha += A[i, j];
                }
                Console.WriteLine(totalLinha);
            }
        }
    }
}
