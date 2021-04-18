using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rotas.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaId = 1,
                    Titulo = "Felipe Massa ganha a F1",
                    Conteudo = "Conteudo",
                    Categoria = "Esportes",
                    Data = new DateTime(2021,04,16)

                },


                 new Noticia
                {
                    NoticiaId = 2,
                    Titulo = "Teste",
                    Conteudo = "Conteudo",
                    Categoria = "Cidade",
                    Data = new DateTime(2021,04,16)

                },

                  new Noticia
                {
                    NoticiaId = 3,
                    Titulo = "Teste",
                    Conteudo = "Conteudo",
                    Categoria = "Cidade",
                    Data = new DateTime(2021,04,16)

                }
                  
            };
        return retorno;
        }
    }
}
