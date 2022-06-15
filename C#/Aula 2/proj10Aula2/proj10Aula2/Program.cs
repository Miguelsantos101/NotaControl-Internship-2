using System;
using System.Globalization;

namespace proj10Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int eventoFabrica, horas, minutos, segundos;

            eventoFabrica = Convert.ToInt32(Console.ReadLine());

            horas = eventoFabrica / 3600;
            minutos = (eventoFabrica % 3600) / 60;
            segundos = eventoFabrica % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
