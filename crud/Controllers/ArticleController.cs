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
                articleService.CreateArticle(article);

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

            return View(articleService.GetArticle(id));
        }

        [HttpPost]
        public ActionResult Edit(Article article)
        {
            if (true)
            {
                articleService.UpdateArticle(article);

                TempData["AlertMessage"] = "Se ha actualizado el artículo";
                TempData["AlertStyle"] = AlertConstants.SUCCESS;

                return RedirectToAction("List");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            TempData["AlertMessage"] = "Se ha eliminado el artículo '" + articleService.GetArticle(id).Name + "'";
            TempData["AlertStyle"] = AlertConstants.SUCCESS;

            articleService.DeleteArticle(id);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            ViewBag.Message = "Lista de artículos existentes";
            return View(articleService.GetArticles());
        }
    }
}
