using System;

namespace ConhecendoVariaveisInstrucoes
{
    class Program
    {
        public int Declaracoes()
        {
            int a;
            int b = 4;
            int c =  5;
            const int d = 6;
            a = 3;

            return a + b + c + d;
        }

        public void InstrucaoIf(int[] arr)
        {               
            if (arr.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (arr.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{arr.Length} argumentos");
            }
        }
        
        public void InstrucaoSwitch(string[] lista)
        {
            int numerosDeArgumentos = lista.Length;
            switch (numerosDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numerosDeArgumentos} argumentos");
                    break;
            }
        
        }

        public void InstrucaoWhile(string[] lista)
        {
            int i = 0;
            while ( i < lista.Length)
            {
                Console.WriteLine($"Item {lista[i]}");
                i++;
            }
        }

        public void InstrucaoDo(string[] textos)
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }

    }
}
