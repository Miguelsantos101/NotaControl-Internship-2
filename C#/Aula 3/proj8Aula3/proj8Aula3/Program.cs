using System;
using System.Globalization;

namespace proj8Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int n1, n2, n3, menor = 0;
            string[] numeros = new string[2];
            numeros = (Console.ReadLine().Split(" "));

            n1 = Convert.ToInt32(numeros[0]);
            n2 = Convert.ToInt32(numeros[1]);
            n3 = Convert.ToInt32(numeros[2]);

            if (n1 < n2 && n1 < n3)
            {
                menor = n1;
            }
            else if (n2 < n1 && n2 < n3)
            {
                menor = n2;
            }
            else if (n3 < n1 && n3 < n2)
            {
                menor = n3;
            }
            else
            {
                menor = n1;
            }

            Console.WriteLine($"MENOR = {menor}");
        }
    }
}
