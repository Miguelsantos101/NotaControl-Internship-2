using System;
using System.Globalization;

namespace proj6Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int codigoInput, senhaInput, codigoTrue = 1234, senhaTrue = 9999;

            Console.WriteLine("Digite o codigo de usuario: ");
            codigoInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a senha: ");
            senhaInput = Convert.ToInt32(Console.ReadLine());

            if (codigoInput != codigoTrue)
            {
                Console.WriteLine("Usuario invalido!");
            }
            else if (senhaInput != senhaTrue)
            {
                Console.WriteLine("Senha incorreta");
            }
            else
            {
                Console.WriteLine("Acesso permitido");
            }
        }
    }
}
