using System;
using AgenciaBancaria.Dominio;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua teste", "12345678", "rio de janeiro", "RJ");
                Cliente cliente = new Cliente("Taiany", "123456", "1233733733", endereco);
                ContaBancaria conta = new ContaBancaria(cliente);

                Console.WriteLine("----------Conta criada------------");
                Console.WriteLine($"Conta:{conta.NumeroConta}-{conta.DigitoVerificador}");
            
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }
}
