using System;

namespace proj11Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            string[] numeros = new string[3];
            numeros = (Console.ReadLine().Split(" "));

            A = Convert.ToInt32(numeros[0]);
            B = Convert.ToInt32(numeros[1]);
            C = Convert.ToInt32(numeros[2]);
            D = Convert.ToInt32(numeros[3]);

            if (B > C && D > A && C + D > B + A && C >= 0 && D >= 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}
