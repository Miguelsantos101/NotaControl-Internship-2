using System;

namespace proj19Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;

            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Dia da semana: Domingo");
                    break;
                case 2:
                    Console.WriteLine("Dia da semana: Segunda");
                    break;
                case 3:
                    Console.WriteLine("Dia da semana: Terca");
                    break;
                case 4:
                    Console.WriteLine("Dia da semana: Quarta");
                    break;
                case 5:
                    Console.WriteLine("Dia da semana: Quinta");
                    break;
                case 6:
                    Console.WriteLine("Dia da semana: Sexta");
                    break;
                case 7:
                    Console.WriteLine("Dia da semana: Sabado");
                    break;
                default:
                    Console.WriteLine("Dia da semana: Valor invalido");
                    break;
            }
        }
    }
}
