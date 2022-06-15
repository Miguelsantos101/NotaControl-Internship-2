using System;

namespace proj10Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[3];
            int[,] A = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            

        }
    }
}
