using System;

namespace proj12Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z = 0, total = 0, contador = 0;

            x = Convert.ToInt32(Console.ReadLine());

            while (z <= x)
            {
                z = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = x; i < z; i++)
            {
                if (total <= z)
                {
                    total += i;
                    contador++;
                }
            }

            Console.WriteLine(contador);
        }
    }
}
