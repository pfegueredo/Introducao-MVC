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
                    Conteudo = "Felipe estava jogando duro na estrada",
                    Categoria = "Esportes",
                    Data = new DateTime(2021,04,16)

                },


                 new Noticia
                {
                    NoticiaId = 2,
                    Titulo = "O COVID-19 desapareceu do mundo",
                    Conteudo = "Após a vacinação em massa, a doença desapareceu",
                    Categoria = "Saude",
                    Data = new DateTime(2021,04,19)

                },

                  new Noticia
                {
                    NoticiaId = 3,
                    Titulo = "Suspeitos presos por trafico de drogas na Cajazeiras",
                    Conteudo = "A policia descobriu uma gang que vendia drogas na porta da escola",
                    Categoria = "Policia",
                    Data = new DateTime(2021,04,17)

                }
                  
            };
        return retorno;
        }
    }
}
