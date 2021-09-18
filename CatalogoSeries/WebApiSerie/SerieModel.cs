﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogoSeries.Classes;

namespace WebApiSerie
{
    public class SerieModel
    {
        public int Id { get; set; }
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }

        public SerieModel() { }

        public SerieModel(Serie serie)
        {
            Id = serie.retornaId();
            Genero = serie.retornaGenero();
            Titulo = serie.retornaTitulo();
            Descricao = serie.retornaDescricao();
            Ano = serie.retornaAno();
            Excluido = serie.retornaExcluido();
        }

        public Serie ToSerie()
        {
            return new Serie(Id, Genero, Titulo, Descricao, Ano);
        }
    }
}