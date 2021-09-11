﻿ using System;

 namespace ConhecendoVariaveisInstrucoes
 {
    class Executar
    {
         static void Main(string[] args)
         {
            Program instrucoes = new Program();
            int soma = instrucoes.Declaracoes();
            Console.WriteLine($"A soma é igual a {soma}");

            int[] arr = { 25, 10, 20, 15, 40, 50 };
            instrucoes.InstrucaoIf(arr);
            
            string[] lista = {"1","2","3"};
            instrucoes.InstrucaoSwitch(lista);

            instrucoes.InstrucaoWhile(lista);
            
            string[] textos = new string[3];
            instrucoes.InstrucaoDo(textos);

            instrucoes.InstrucaoFor(lista);

            instrucoes.InstrucaoForeach(lista);
         }
     }
 } 

