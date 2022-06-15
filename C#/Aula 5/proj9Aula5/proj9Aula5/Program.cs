using System;

namespace proj9Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            while (N != 0)
            {
                if (N <= 1)
                {
                    Console.WriteLine("1\n");
                }
                else
                {

                    int[,] A = new int[N, N];

                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            A[i, j] = Math.Abs((i-j))+1;
                        }
                    }

                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            Console.Write($"{A[i, j]} ");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                }
                N = int.Parse(Console.ReadLine());
            }
        }
    }
}
