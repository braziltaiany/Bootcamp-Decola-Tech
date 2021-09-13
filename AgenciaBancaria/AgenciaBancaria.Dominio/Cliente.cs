using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        //Criando um construtor
        public Cliente(string nome, string cpf, string rg, string logradouro, string cep, string cidade, string estado) 
        {
            //verificando se a string está vazia com o método string.IsNullOrWhiteSpace() 
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Propriedade deve estar preenchida.");
            }


            Nome = nome;
            
            // ou podemos utilizar o operador ? que faz a mesma coisa que o if acima
            CPF = string.IsNullOrWhiteSpace(cpf) ?
                throw new Exception("Propriedade deve estar preenchida.")
                : cpf;

            RG = string.IsNullOrWhiteSpace(rg) ?
                throw new Exception("Propriedade deve estar preenchida.")
                : rg;

            Logradouro = string.IsNullOrWhiteSpace(logradouro) ?
                throw new Exception("Propriedade deve estar preenchida.")
                : logradouro;

            CEP = string.IsNullOrWhiteSpace(cep) ?
                throw new Exception("Propriedade deve estar preenchida.")
                : cep;

            Cidade = string.IsNullOrWhiteSpace(cidade) ?
                throw new Exception("Propriedade deve estar preenchida.")
                : cidade;

            Estado = string.IsNullOrWhiteSpace(estado) ?
                throw new Exception("Propriedade deve estar preenchida.")
                : estado;
        }
        
        //acessor public e propriedades Nome, somente dentro da classe nome podemos setar a propriedade nome
        //PROP+ TAB duas vezes adiciona uma propriedade automaticamente
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

    }
}
