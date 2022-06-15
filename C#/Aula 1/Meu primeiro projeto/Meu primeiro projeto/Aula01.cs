using System;
using System.Globalization;

namespace Meu_primeiro_projeto
{
    class Aula01
    {
        static void Main(string[] args)
        {
            /*double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais!");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            Console.WriteLine();*/


            /*int x;
            double y;
            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);*/

            int valor = ((2 + 33 + 3) * 2) + (1400 - 100) * 3;

            Console.WriteLine($"Valor = {valor:F5}");

            /*double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            Console.WriteLine(area);*/


            //-------------------------------------------------------------------------------------------
            //Casting - conversão de tipos

            /*int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = (double) a / b;

            Console.WriteLine(resultado);*/

            /*double a;
            int b;

            a = 5.0;
            b = (int) a;

            Console.WriteLine(b);*/

            //-------------------------------------------------------------------------------------------
            //Exercicios - Beecrowd

            /*int A, B, SOMA;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            SOMA = A + B;
            Console.WriteLine("SOMA = " + SOMA);*/

            int A, B, PROD;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            PROD = A * B;
            Console.WriteLine("PROD = " + PROD);

        }
    }
}
