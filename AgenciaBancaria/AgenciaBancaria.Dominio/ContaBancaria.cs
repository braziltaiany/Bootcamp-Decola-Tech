using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    //utilização do abstract para garantir criar conta corrente ou conta poupança, impedindo de criar conta bancaria diretamente. Po´rem ela pode ser herdada
    public abstract class ContaBancaria
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
            senha = senha.ValidaStringVazia();

            // regras para traballhar com string, preciso verificar se uma determinada regra que vamos atribuir é valida
            // pra isso utilizaremos o regex
            // Mínimo de oito caracteres, pelo menos uma letra e um número
            if (!Regex.IsMatch(senha, @"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$"))
            {
                throw new Exception("Senha inválida");
            }

            Senha = senha;

          
        }

        //Polimorfismo é utilizar o mesmo método com comportamentos diferentes
        public  virtual void Sacar(decimal valor, string senha)
        {
            if (senha != Senha)
            {
                throw new Exception("Senha incorreta.");
            }

            

            if (Saldo < valor)
            {
                throw new Exception("Saldo indisponível.");
            }

            Saldo -=  valor;

            
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
