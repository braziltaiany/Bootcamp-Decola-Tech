using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Cliente cliente, decimal limite): base(cliente)
        {
            ValorTaxaManutencao = 0.05M;
            Limite = limite;
        }
        //override sobrescreve o método sacar
        //Mudar o comportamento do conta bancaria - utilizando o virtual em Sacar() em contaBancaria
        public override void Sacar(decimal valor, string senha)
        {
            if (senha != Senha)
            {
                throw new Exception("Senha incorreta.");
            }



            if (Saldo + Limite < valor)
            {
                throw new Exception("Saldo indisponível.");
            }

            Saldo -= valor;


        }
        public decimal Limite { get; private set; }
        public decimal ValorTaxaManutencao { get; private set; }
    }
}
