using System;

namespace proj14Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal1, animal2, animal3, escolha;

            animal1 = Console.ReadLine();
            animal2 = Console.ReadLine();
            animal3 = Console.ReadLine();


            if (animal1 == "vertebrado")
            {
                if (animal2 == "ave")
                {
                    if (animal3 == "carnivoro")
                    {
                        escolha = "aguia";
                    }
                    else
                    {
                        escolha = "pomba";
                    }
                }
                else
                {
                    if (animal3 == "onivoro")
                    {
                        escolha = "homem";
                    }
                    else
                    {
                        escolha = "vaca";
                    }
                }
            }
            else
            {
                if (animal2 == "inseto")
                {
                    if (animal3 == "hematofago")
                    {
                        escolha = "pulga";
                    }
                    else
                    {
                        escolha = "lagarta";
                    }
                }
                else
                {
                    if (animal3 == "hematofago")
                    {
                        escolha = "sanguessuga";
                    }
                    else
                    {
                        escolha = "minhoca";
                    }
                }
            }

            Console.WriteLine($"{escolha}");
        }
    }
}
