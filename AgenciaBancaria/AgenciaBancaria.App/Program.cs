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
                
                //ContaBancaria conta = new ContaCorrente(cliente); //agora irá dar erro por causa do abstract
                ContaCorrente conta = new ContaCorrente(cliente);

                Console.WriteLine("----------Conta Criada------------");
                Console.WriteLine($"Cliente: {cliente.Nome} CPF: {cliente.CPF}");
                Console.WriteLine("");
                Console.WriteLine($"Situação:{conta.Situacao}       Conta:{conta.NumeroConta}-{conta.DigitoVerificador}");
                Console.WriteLine("");
                Console.WriteLine("************************************");
                Console.WriteLine("");
                
                string  senha = "abc12345";
                conta.Abrir(senha);
                Console.WriteLine("----------Conta Aberta------------");
                Console.WriteLine("");
                Console.WriteLine($"Situação:{conta.Situacao}       Conta:{conta.NumeroConta}-{conta.DigitoVerificador}");
               
                Console.WriteLine("");
                Console.WriteLine("----------SAQUE------------");
                Console.WriteLine("");
                conta.Sacar(10, senha);
                Console.WriteLine(conta.Saldo);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }
}
