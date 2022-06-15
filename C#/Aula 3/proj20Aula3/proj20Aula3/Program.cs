using System;

namespace proj20Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Alimento nao-perecivel");
                    break;
                case <= 4:
                    Console.WriteLine("Alimento perecivel");
                    break;
                case <= 6:
                    Console.WriteLine("Vestuario");
                    break;
                case 7:
                    Console.WriteLine("Higiene Pessoal");
                    break;
                case <= 15:
                    Console.WriteLine("Limpeza e Utensilios Domesticos");
                    break;
                default:
                    Console.WriteLine("Codigo invalido");
                    break;
            }
        }
    }
}
