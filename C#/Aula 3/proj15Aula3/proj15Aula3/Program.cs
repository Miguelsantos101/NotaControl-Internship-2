using System;

namespace proj15Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, E, pares = 0, impares = 0, negativos = 0, positivos = 0;

            A = Convert.ToInt32(Console.ReadLine());
            if (A > 0)
            {
                positivos++;
            }
            else if (A < 0)
            {
                negativos++;
            }
            if (A % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }

            B = Convert.ToInt32(Console.ReadLine());
            if (B > 0)
            {
                positivos++;
            }
            else if (B < 0)
            {
                negativos++;
            }
            if (B % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }

            C = Convert.ToInt32(Console.ReadLine());
            if (C > 0)
            {
                positivos++;
            }
            else if (C < 0)
            {
                negativos++;
            }
            if (C % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }

            D = Convert.ToInt32(Console.ReadLine());
            if (D > 0)
            {
                positivos++;
            }
            else if (D < 0)
            {
                negativos++;
            }
            if (D % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }

            E = Convert.ToInt32(Console.ReadLine());
            if (E > 0)
            {
                positivos++;
            }
            else if (E < 0)
            {
                negativos++;
            }
            if (E % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }

            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impares} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");
        }
    }
}
