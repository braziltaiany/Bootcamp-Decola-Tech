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
                Cliente cliente = new Cliente(
                "Taiany",
                "123456",
                "1233733733",
                "teste",
                "12345678",
                "rio de janeiro",
                "RJ");
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }
}
