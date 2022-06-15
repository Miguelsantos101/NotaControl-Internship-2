using System;

namespace proj2Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, total = 0;

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                for (int i = y + 1; i < x; i++)
                {
                    if (i % 2 != 0)
                    {
                        total += i;
                    }
                }
            }
            else if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    if (i % 2 != 0)
                    {
                        total += i;
                    }
                }
            }
            else
            {
                total = 0;
            }

            Console.WriteLine(total);
        }
    }
}
