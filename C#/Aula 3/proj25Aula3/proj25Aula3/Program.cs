using System;

namespace proj25Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            senha = Convert.ToInt32(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida");
                senha = Convert.ToInt32(Console.ReadLine());
            }

            if (senha == 2002)
            {
                Console.WriteLine("Acesso Permitido");
            }


        }
    }
}
