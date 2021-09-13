using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public enum SituacaoConta //  public enum SituacaoConta: int por padrão ele herda de int, todos os valores representam um numero
    {
        Criada = 1,
        Aberta = 2,
        Encerrada = 3
    }
}
