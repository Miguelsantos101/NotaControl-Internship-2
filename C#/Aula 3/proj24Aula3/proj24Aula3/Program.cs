using System;

namespace proj24Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, xAnt = 0, qtdNum = 1, media;


            x = Convert.ToInt32(Console.ReadLine());
            while (x > 0)
            {
                media = (x + xAnt) / qtdNum;
                xAnt += x;
                Console.WriteLine(media);

                qtdNum++;
                x = Convert.ToInt32(Console.ReadLine());
            } 

            if (x <= 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
