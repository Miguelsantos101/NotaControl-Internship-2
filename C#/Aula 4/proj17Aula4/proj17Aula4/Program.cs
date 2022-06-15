using System;

namespace proj17Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = Convert.ToInt32(Console.ReadLine());
            string[] nomes = new string[n];
            for (int i = 0; i < n; i++)
            {
                nomes[i] = Console.ReadLine();

            }
            
            for (int j = 0; j < nomes.Length; j++)
            {
                if (j == 0)
                {
                    Console.WriteLine("Nomes lidos:");
                }
                Console.WriteLine(nomes[j]);
            }
        }
    }
}
