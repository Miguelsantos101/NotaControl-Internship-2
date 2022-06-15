using System;

namespace proj10Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, contador = 0;
            string[] numeros = new string[1];
            numeros = Console.ReadLine().Split(" ");

            x = Convert.ToInt32(numeros[0]);
            y = Convert.ToInt32(numeros[1]);

            for (int i = 1; i <= y; i++)
            {

                if(contador < x)
                {
                    Console.Write($"{i} ");
                    contador++;
                }
                else
                {
                    Console.Write($"\n{i} ");
                    contador = 1;
                }
            }
        }
    }
}
