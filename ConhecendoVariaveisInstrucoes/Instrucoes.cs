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

        
        }    
    }
}
