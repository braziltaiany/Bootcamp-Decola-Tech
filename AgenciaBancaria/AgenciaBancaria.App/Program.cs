using System;
using AgenciaBancaria.Dominio;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(
                "Taiany", 
                "123456", 
                "1233733733", 
                "teste", 
                "12345678", 
                "rio de janeiro", 
                "RJ");

            Console.WriteLine(cliente.Nome);
        }

    }
}
