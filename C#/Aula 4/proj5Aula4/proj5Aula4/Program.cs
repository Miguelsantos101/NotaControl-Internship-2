using System;

namespace proj5Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, dentro = 0, fora = 0;

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
