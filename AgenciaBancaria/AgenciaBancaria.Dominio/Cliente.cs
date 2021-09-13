using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public Cliente(string nome, string cpf, string rg, string logradouro, string cep, string cidade, string estado)
        {
            Nome = ValidaStringVazia(nome);
            CPF = ValidaStringVazia(cpf);
            RG = ValidaStringVazia(rg);
            Logradouro = ValidaStringVazia(logradouro);
            CEP = ValidaStringVazia(cep);
            Cidade = ValidaStringVazia(cidade);
            Estado = ValidaStringVazia(estado);

        }
        private static string ValidaStringVazia(string texto)
        {

            return string.IsNullOrWhiteSpace(texto) ?
                throw new Exception("Propriedade deve estar preenchida.") : texto;
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
}   }