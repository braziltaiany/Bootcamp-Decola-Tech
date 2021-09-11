using System;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indeceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;      
                        }
                        else
                        {
                            throw new ArgumentException(" Valor da nota deve ser decimal");
                        }
                        
                        alunos[indeceAluno] = aluno;
                        indeceAluno++;
                        
                        break;

                    case "2":
                        foreach (var alunoA in alunos)
                        {   
                            if(!string.IsNullOrEmpty(alunoA.Nome))
                            {
                                Console.WriteLine($"ALUNO: {alunoA.Nome} - NOTA: {alunoA.Nota}");
                            }
                        }
                        
                        break;

                    case "3":
                        //TODO: calcular média geral
                        break;

                    default: throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir Novo Aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
