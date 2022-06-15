using System;

namespace proj12Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaI, horaF, total = 0;
            string[] numeros = new string[1];
            numeros = (Console.ReadLine().Split(" "));

            horaI = Convert.ToInt32(numeros[0]);
            horaF = Convert.ToInt32(numeros[1]);

            if (horaI > horaF)
            {
                total = (24 - horaI) + horaF;
               
            }
            else if (horaI < horaF)
            {
                total = horaF - horaI;
            }
            else
            {
                total = 24;
            }

            Console.WriteLine($"{total}");
        }
    }
}
