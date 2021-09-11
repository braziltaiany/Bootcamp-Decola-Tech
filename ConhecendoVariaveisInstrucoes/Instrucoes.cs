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

        public void InstrucaoIf(int[] numeros)
        {               
            if (numeros.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (numeros.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{numeros.Length} argumentos");
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

        public void InstrucaoFor(string[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine($"{lista[i]}º item é : {lista[i]}.");
            }
        }
        
        public void InstrucaoForeach(string[] lista)
        {
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void InstrucaoBreak(string[] textos)
        {
            while (true)
            {
                string item = Console.ReadLine();

                if (string.IsNullOrEmpty(item))
                {
                    break;
                }

                Console.WriteLine(item);
            }
        }

        public void InstrucaoContinue(string[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i].StartsWith("/"))
                {
                    continue;
                }

                Console.WriteLine($"Olá, quero {lista[i]} café.");
            }
        }

        public void InstrucaoReturn()
        {
            int Somar (int a, int b)
            {
                return a + b;
            }
            
            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
            return;
        }

        public void InstrucoesTryCatchFinallyThrow(string[] lista)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            try
            {
                if (lista.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }

                double x = double.Parse(lista[0]);
                double y = double.Parse(lista[1]);
                Console.WriteLine(Dividir(x, y));
            }
            catch (InvalidOperationException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine($"Erro genérico: {err.Message}");
            }
            finally
            {
                Console.WriteLine("Até breve!");
            }
        }
    }
}
