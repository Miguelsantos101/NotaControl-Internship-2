using System;

namespace proj10Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;

            dia = Convert.ToInt32(Console.ReadLine());

            if (dia == 1)
            {
                Console.WriteLine("Dia da semana: Domingo");
            }
            else if (dia == 2)
            {
                Console.WriteLine("Dia da semana: Segunda");
            }
            else if (dia == 3)
            {
                Console.WriteLine("Dia da semana: Terca");
            }
            else if (dia == 4)
            {
                Console.WriteLine("Dia da semana: Quarta");
            }
            else if (dia == 5)
            {
                Console.WriteLine("Dia da semana: Quinta");
            }
            else if (dia == 6)
            {
                Console.WriteLine("Dia da semana: Sexta");
            }
            else if (dia == 7)
            {
                Console.WriteLine("Dia da semana: Sabado");
            }
            else
            {
                Console.WriteLine("Dia da semana: Valor invalido");
            }
        }
    }
}
