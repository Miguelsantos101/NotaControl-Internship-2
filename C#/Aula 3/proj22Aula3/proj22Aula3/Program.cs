using System;
using System.Globalization;

namespace proj22Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int codigo = 999, quantidade;
            double total = 0;

            codigo = Convert.ToInt32(Console.ReadLine());

            while (codigo != 000)
            {
                quantidade = Convert.ToInt32(Console.ReadLine());
                switch (codigo)
                {
                    case 100:
                        total = quantidade * 1.70;
                        break;
                    case 101:
                        total = quantidade * 2.30;
                        break;
                    case 102:
                        total = quantidade * 2.60;
                        break;
                    case 103:
                        total = quantidade * 2.40;
                        break;
                    case 104:
                        total = quantidade * 2.50;
                        break;
                    case 105:
                        total = quantidade * 1;
                        break;
                    case 000:
                        break;
                }
                Console.WriteLine($"Valor a pagar: R${total:F2}");
                codigo = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
