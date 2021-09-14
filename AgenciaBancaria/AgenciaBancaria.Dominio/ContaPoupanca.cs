using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    //Conta poupança herda de contabancaria, tudo que conta bancaria tem a conta poupança também tem.

    public class ContaPoupanca : ContaBancaria
    {
        //criaando um construtor 
        //herda da base mãe Contabancaria - F12 em cima da  base mostra isso
        public ContaPoupanca(Cliente cliente): base(cliente)
        {
            //Para clientes - não precisa fazer mais nada aqui porque já herda

            //0,30%
            PercentualRendimento = 0.003M;

        }

        public decimal PercentualRendimento { get; private set; }
    }
}
