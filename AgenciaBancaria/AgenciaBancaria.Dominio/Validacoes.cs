using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public static class Validacoes
    {
        // o método THIS torna o médoto de extensão podendo chamar o médodo de outra forma 
        // exemplo: Nome = nome.ValidaStringVazia() o que antes estava assim: ValidaStringVazia(nome);

        public static string ValidaStringVazia(this string texto)
        {

            return string.IsNullOrWhiteSpace(texto) ?
                throw new Exception("Propriedade deve estar preenchida.") : texto;
        }
    }
}
