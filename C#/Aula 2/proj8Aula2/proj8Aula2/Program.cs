using System;
using System.Globalization;

namespace proj8Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int numero, horasTrab;
            double valorHora, salario;
            numero = Convert.ToInt32(Console.ReadLine());
            horasTrab = Convert.ToInt32(Console.ReadLine());
            valorHora = Convert.ToDouble(Console.ReadLine());
            

            salario = horasTrab *  valorHora;

            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
        }
    }
}
