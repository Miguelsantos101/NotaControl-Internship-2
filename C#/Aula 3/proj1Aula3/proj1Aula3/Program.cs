using System;
using System.Globalization;

namespace proj1Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double nota;

            nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 6)
            {
                Console.WriteLine("O aluno esta aprovado: True");
            }
            else
            {
                Console.WriteLine("O aluno esta aprovado: False");
            }

        }
    }
}
