using System;

namespace proj14Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = Convert.ToInt32(Console.ReadLine());

            string[] entrada = Console.ReadLine().Split(" ");

            for (int i = 0; i < n; i++)
            {
                if (Convert.ToInt32(entrada[i]) < 0)
                {
                    Console.WriteLine(entrada[i]);
                }
            }
        }
    }
}
