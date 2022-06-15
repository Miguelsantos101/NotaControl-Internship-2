using System;

namespace proj23Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] numeros = new string[1];
            numeros = (Console.ReadLine().Split(" "));
            x = Convert.ToInt32(numeros[0]);
            y = Convert.ToInt32(numeros[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }

                numeros = (Console.ReadLine().Split(" "));

                x = Convert.ToInt32(numeros[0]);
                y = Convert.ToInt32(numeros[1]);
            }
        }
    }
}
