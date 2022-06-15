using System;

namespace proj21Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, opcode;

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());

            opcode = Convert.ToInt32(Console.ReadLine());

            switch (opcode)
            {
                case 1:
                    Console.WriteLine($"Media entre {numero1} e {numero2}: {numero1+numero2/2}");
                    break;
                case 2:
                    Console.WriteLine($"Diferenca entre {numero1} e {numero2}: {numero1 - numero2}");
                    break;
                case 3:
                    Console.WriteLine($"Produto entre {numero1} e {numero2}: {numero1 * numero2}");
                    break;
                case 4:
                    Console.WriteLine($"Divisao entre {numero1} e {numero2}: {numero1 / numero2}");
                    break;
            }
        }
    }
}
