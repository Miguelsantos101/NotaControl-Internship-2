using System;

namespace proj4Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                Console.WriteLine(i);
            }
        }
    }
}
