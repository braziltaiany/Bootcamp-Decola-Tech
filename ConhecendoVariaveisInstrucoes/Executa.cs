 using System;

 namespace ConhecendoVariaveisInstrucoes
 {
    class Executar
    {
         static void Main(string[] args)
         {
            Program instrucoes = new Program();
            int soma = instrucoes.Declaracoes();
            Console.WriteLine($"A soma é {soma}");

            int[] arr = { 25, 10, 20, 15, 40, 50 };
            instrucoes.InstrucaoIf(arr);
            
            string[] lista = {"1","2","3"};
            instrucoes.InstrucaoSwitch(lista);

            instrucoes.InstrucaoWhile(lista);
            
         }
     }
 } 

