using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class CategoryController : BaseController
    {
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Message = "Ingrese los datos de la categoría.";

            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryService.CreateCategory(category);
                
                TempData["AlertMessage"] = "Se ha agregado la categoría.";
                TempData["AlertStyle"] = AlertConstants.SUCCESS;

                return RedirectToAction("List");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            TempData["AlertMessage"] = "Se ha eliminado la categoría '" + categoryService.GetCategory(id).Name + "'";
            TempData["AlertStyle"] = AlertConstants.SUCCESS;

            categoryService.DeleteCategory(id);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            ViewBag.Message = "Lista de categorias existentes.";

            return View(categoryService.GetCategories());
        }
    }
}