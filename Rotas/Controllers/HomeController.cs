using Rotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> noticias; // = new Noticia().TodasAsNoticias();
        public HomeController()
        {
            noticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);
        }

        public ActionResult Index()
        {
            var ultimasNoticias = noticias.Take(3);
            var todasAsCategorias = noticias.Select(x => x.Categoria).Distinct();
            ViewBag.Categorias = todasAsCategorias;

            return View(ultimasNoticias);
        }

        public ActionResult MostrarCategoria(string categoria)
        {

            ViewBag.Categoria = categoria;
            return View(noticias.Where(x => x.Categoria.Equals(categoria.ToLower())).FirstOrDefault());
        }

        public ActionResult TodasAsNoticias()
        {
            return View(noticias);
        }

        public ActionResult MostrarNoticia(string noticiaId, string categoria, string titulo)
        {
            ViewBag.NoticiaId = noticiaId;
            ViewBag.Categoria = categoria;
            ViewBag.Titulo = titulo;

            return View(noticias.FirstOrDefault(x => x.NoticiaId.ToString() == noticiaId));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}