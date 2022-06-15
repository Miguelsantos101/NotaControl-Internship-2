using System;
using System.Globalization;

namespace proj4Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double litros, total = 0;
            char tipoCombustivel;

            Console.WriteLine("Digite a quantidade de litros: ");
            litros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o tipo de combustivel A (Alcool), G (Gasolina): ");
            tipoCombustivel = Convert.ToChar(Console.ReadLine());
            string combustivel = tipoCombustivel == 'A' ? "alcool" : "gasolina";

            if (tipoCombustivel == 'A' && litros <= 20)
            {
                total = (litros * 4.90) * 0.97;
            }
            else if (tipoCombustivel == 'A' && litros > 20)
            {
                total = (litros * 4.90) * 0.95;
            }
            else if (tipoCombustivel == 'G' && litros <= 20)
            {
                total = (litros * 7.30) * 0.96;
            }
            else if (tipoCombustivel == 'G' && litros > 20)
            {
                total = (litros * 7.30) * 0.94;
            }


            Console.WriteLine($"O total a ser pago de {combustivel} e de: {total:F2}");
        }
    }
}
