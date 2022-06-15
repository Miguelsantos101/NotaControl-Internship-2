using System;
using System.Globalization;

namespace proj6Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int N, linha, coluna, linhaPos = 0, colunaPos = 0, diagonalPos = 0;
            double positivos = 0;
            double[] linhaV, colunaV, diagonalV;
            double[,] A;

            N = int.Parse(Console.ReadLine());
            A = new double[N, N];
            linhaV = new double[N];
            colunaV = new double[N];
            diagonalV = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = double.Parse(s[j]);
                }
            }

            linha = int.Parse(Console.ReadLine());
            coluna = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] > 0)
                    {
                        positivos += A[i, j];
                    }

                    if (linha == i)
                    {
                        linhaV[linhaPos] = A[i, j];
                        linhaPos++;
                    }

                    if (coluna == j)
                    {
                        colunaV[colunaPos] = A[i, j];
                        colunaPos++;
                    }

                    if (i == j)
                    {
                        diagonalV[diagonalPos] = A[i, j];
                        diagonalPos++;
                    }
                }
            }

            Console.WriteLine($"SOMA DOS POSITIVOS: {positivos:F1}");

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    Console.Write($"LINHA ESCOLHIDA: {linhaV[i]:F1} ");
                }
                else
                {
                    Console.Write($"{linhaV[i]:F1} ");
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    Console.Write($"\nCOLUNA ESCOLHIDA: {colunaV[i]:F1} ");
                }
                else
                {
                    Console.Write($"{colunaV[i]:F1} ");
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    Console.Write($"\nDIAGONAL PRINCIPAL: {diagonalV[i]:F1} ");
                }
                else
                {
                    Console.Write($"{diagonalV[i]:F1} ");
                }
            }


            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("\nMATRIZ ALTERADA:");
                }
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        Console.Write($"{Math.Pow(A[i, j], 2):F1} ");
                    }
                    else
                    {
                        Console.Write($"{A[i, j]:F1} ");
                    }
                        
                }
                Console.WriteLine("");
            }
        }
    }
}
