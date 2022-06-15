using System;
using System.Globalization;

namespace proj18Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double nota1, nota2, nota3, mediaEx, mediaAp;
            char nota;

            nota1 = Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());
            nota3 = Convert.ToDouble(Console.ReadLine());
            mediaEx = Convert.ToDouble(Console.ReadLine());

            mediaAp = (nota1 + (nota2 * 2) + (nota3 * 3) + mediaEx) / 7;

            if (mediaAp < 6)
            {
                nota = 'D';
            }
            else if (mediaAp < 7.5)
            {
                nota = 'C';
            }
            else if (mediaAp < 9)
            {
                nota = 'B';
            }
            else
            {
                nota = 'A';
            }

            Console.WriteLine($"Nota: {nota}");
        }
    }
}
