using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSerie
{
    public class SerieModel
    {
        public int Id { get; set; }        
        private CatalogoSeries.Series.Genero Genero { get; set; }
       // public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }
    }
}
