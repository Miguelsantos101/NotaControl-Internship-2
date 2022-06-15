using System;
using System.Globalization;

namespace proj2Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int idade;
            bool associado;

            idade = Convert.ToInt32(Console.ReadLine());
            associado = Convert.ToBoolean(Console.ReadLine());
            
            if (idade >= 65 || associado)
            {
                Console.WriteLine("A pessoa possui desconto");

            }
            else
            {
                Console.WriteLine("A pessoa NAO possui desconto");
            }


        }
    }
}
