using System;

namespace proj27Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, total = 0;

            x = Convert.ToInt32(Console.ReadLine());

            while (x != 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (x % 2 == 0)
                    {
                        total += x;
                    }
                    x++;
                }

                Console.WriteLine(total);
                total = 0;
                x = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
