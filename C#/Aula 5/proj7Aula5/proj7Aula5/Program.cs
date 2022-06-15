using System;

namespace proj7Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, numeroFila;
            int[,] A;

            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            numeroFila = int.Parse(Console.ReadLine()) - 1;

            for (int i = 0; i < M; i++)
            {
                int temp = 0;
                for (int j = 0; j < N; j++)
                {

                    if (i == numeroFila)
                    {
                        if (j == 0)
                        {
                            Console.Write($"{A[i, N - 1]} ");
                            temp = A[i, j];
                        }
                        else if (j > 0)
                        {
                            Console.Write($"{temp} ");
                            temp = A[i, j];
                        }
                    }
                    else
                    {
                        Console.Write($"{A[i, j]} ");
                    }

                }
                Console.WriteLine("");
            }

        }
    }
}
