using System;
using System.Globalization;

namespace proj5Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double maca, morango, totalMaca, totalMorango, totalValor = 0;

            Console.WriteLine("Qual a quantidade de macas (Kg)? ");
            maca = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a quantidade de morangos (Kg)? ");
            morango = Convert.ToDouble(Console.ReadLine());

            if (maca <= 5)
            {
                totalMaca = maca * 1.80;
            }
            else
            {
                totalMaca = maca * 1.50;
            }

            if (morango <= 5)
            {
                totalMorango = morango * 2.50;
            }
            else
            {
                totalMorango = morango * 2.20;
            }

            if (maca + morango >= 8 || totalMorango + totalMaca >= 25)
            {
                totalValor = (totalMorango + totalMaca) * 0.90;
            }

            Console.WriteLine($"O total a ser pago e de: R${totalValor:F2}");
        }
    }
}
