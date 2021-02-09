using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rotas.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public DateTime Data { get; set; }
        public string Conteudo { get; set; }
        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia {
                    Categoria = "esporte",
                    Data = new DateTime(2020,02,20),
                    Conteudo = "blablabla esporte",
                    NoticiaId = 1,
                    Titulo = "vitória time desce"
                },

                new Noticia {
                    Categoria = "saúde",
                    Data = new DateTime(2020,02,20),
                    Conteudo = "blablabla saúde",
                    NoticiaId = 2,
                    Titulo = "vitamina c é bom"
                }
            };


            return retorno;
           
        }






    }
}