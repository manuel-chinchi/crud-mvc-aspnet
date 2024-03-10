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
            ViewBag.Categories = _categoryService.GetCategories();

            return View();
        }

        [HttpPost]
        public ActionResult Create(Article article)
        {
            article.Category = _categoryService.GetCategory(article.CategoryId);

            if (ModelState.IsValid)
            {
                _articleService.CreateArticle(article);

                TempData["AlertMessage"] = "Se ha agregado el artículo";
                TempData["AlertType"] = AlertType.SUCCESS;

                return RedirectToAction("List");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Message = "Datos del artículo";
            ViewBag.Categories = _categoryService.GetCategories();

            return View(_articleService.GetArticle(id));
        }

        [HttpPost]
        public ActionResult Edit(Article article)
        {
            article.Category = _categoryService.GetCategory(article.CategoryId);

            if (ModelState.IsValid)
            {
                _articleService.UpdateArticle(article);

                TempData["AlertMessage"] = "Se ha actualizado el artículo";
                TempData["AlertType"] = AlertType.SUCCESS;

                return RedirectToAction("List");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            TempData["AlertMessage"] = "Se ha eliminado el artículo '" + _articleService.GetArticle(id).Name + "'";
            TempData["AlertType"] = AlertType.SUCCESS;

            _articleService.DeleteArticle(id);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            ViewBag.Message = "Lista de artículos existentes";
            return View(_articleService.GetArticles());
        }
    }
}
