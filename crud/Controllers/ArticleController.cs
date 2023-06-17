using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class ArticleController : BaseController
    {
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

            Article article = articleService.GetArticles().Where(x => x.Id == id).FirstOrDefault();

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

        public ActionResult Delete(int id)
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            ViewBag.Message = "Lista de artículos existentes";
            return View(articleService.GetArticles());
        }
    }
}
