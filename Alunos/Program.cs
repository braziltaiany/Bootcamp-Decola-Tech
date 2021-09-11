using System;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = Console.ReadLine();

            while (opcaoUsuario.ToUpper() != "X")
            {
                 switch (opcaoUsuario)
                 {
                    case "1":
                        //TODO: adicionar aluno
                        break;
                    case "2":
                        //TODO: listar alunos
                        break;
                    case "3":
                        //TODO: calcular média geral
                        break;
                         
                    default: throw new ArgumentOutOfRangeException();

                 }
                    Console.WriteLine("Informe a opção desejada:");
                    Console.WriteLine("1- Inserir Novo Aluno");
                    Console.WriteLine("2- Listar Alunos");
                    Console.WriteLine("3- Calcular média geral");
                    Console.WriteLine("X- Sair");
                    Console.WriteLine();
                    
                    opcaoUsuario = Console.ReadLine();
            }
        }
    }
}
