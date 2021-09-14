using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaBancaria
    {
        //construtor
        public ContaBancaria(Cliente cliente)
        {
            // estou garantindo que minha conta sempre quando criar sempre terá numero da conta e digito verificador
            Random random = new Random();
            NumeroConta = random.Next(50000, 100000);
            DigitoVerificador = random.Next(0, 9);
            Situacao = SituacaoConta.Criada;
        }

        public void Abrir(string senha)
        {

            SetaSenha(senha);

            Situacao = SituacaoConta.Aberta;
            
            DataAbertura = DateTime.Now;
        }

        private void SetaSenha(string senha)
        {
            Senha = senha.ValidaStringVazia();
        }

        public int NumeroConta { get; init; }// init significa so posso setar os valores de NumeroConta na inicialização da minha classe no construtor
        public int DigitoVerificador { get; init; }// NumeroConta esse campo não podem ser modificados
        public decimal Saldo { get; protected set; }// minhas classes filhas, as classes que herdarem pode setar a propriedade saldo
        public DateTime? DataAbertura { get; private set; }
        public DateTime? DataEncerramento { get; private set; }
        public SituacaoConta Situacao { get; private set; }
        public string Senha { get; private set; }
        public Cliente Cliente { get; init; }
       
    }
}
