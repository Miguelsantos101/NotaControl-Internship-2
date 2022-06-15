using System;

namespace proj9Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, total = 0;

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entrada = new string[1];
                entrada = Console.ReadLine().Split(" ");

                x = Convert.ToInt32(entrada[0]);
                y = Convert.ToInt32(entrada[1]);

                if (x > y)
                {
                    for (int a = y + 1; a < x; a++)
                    {
                        if (a % 2 != 0)
                        {
                            total += a;
                        }
                    }
                }
                else if (x < y)
                {
                    for (int a = x + 1; a < y; a++)
                    {
                        if (a % 2 != 0)
                        {
                            total += a;
                        }
                    }
                }
                else
                {
                    total = 0;
                }

                Console.WriteLine(total);
                total = 0;
            }
        }
    }
}
