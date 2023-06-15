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

        // GET: Article/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Message = "Ingrese los datos del artículo";
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //return RedirectToAction("Index");
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        [HttpGet]
        public ActionResult Edit(int id = 1)
        {
            ViewBag.Description = "Datos del artículo";
            return View(articles[0]);
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                int indexItem = articles.FindIndex(x => x.Id == Convert.ToInt32(collection["Id"]));

                Article articleEdit = articles.Where(x => x.Id == id).FirstOrDefault();
                articleEdit.Name = collection["Name"];
                articleEdit.Description = collection["Description"];
                articleEdit.Quantity = Convert.ToInt32(collection["Quantity"]);

                articles.RemoveAt(indexItem);
                articles.Insert(indexItem, articleEdit);

                //return View("List");
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
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
