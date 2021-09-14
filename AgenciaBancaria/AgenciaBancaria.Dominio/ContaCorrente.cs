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

        public decimal Limite { get; set; }
        public decimal ValorTaxaManutencao { get; private set; }
    }
}
