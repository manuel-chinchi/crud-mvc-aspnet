using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class ArticleController : Controller
    {
        static List<Article> articles;

        public ArticleController()
        {
            articles = new List<Article>();
            articles.Add(new Article() { Id = 1, Name = "zapatilla", Description = "nike, talle 43", Quantity = 100 });
            articles.Add(new Article() { Id = 2, Name = "remera", Description = "talle M", Quantity = 50 });
            articles.Add(new Article() { Id = 3, Name = "sombrero", Description = "chino", Quantity = 100 });
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Message = "Ingrese los datos del artículo";

            return View();
        }

        [HttpPost]
        public ActionResult Create(Article article)
        {
            if (true)
            {
                TempData["AlertMessage"] = "Se ha agregado el artículo";
                TempData["AlertStyle"] = AlertConstants.SUCCESS;

                return RedirectToAction("List");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Message = "Datos del artículo";
            ViewBag.Categories = null;

            Article article = articles.Where(x => x.Id == id).FirstOrDefault();

            return View(article);
        }

        [HttpPost]
        public ActionResult Edit(Article article)
        {
            if (true)
            {
                TempData["AlertMessage"] = "Se ha actualizado el artículo";
                TempData["AlertStyle"] = AlertConstants.SUCCESS;

                return RedirectToAction("List");
            }

            return View();
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            //return View();
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            ViewBag.Message = "Lista de artículos existentes";
            return View(articles);
        }
    }
}
