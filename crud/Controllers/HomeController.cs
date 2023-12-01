using crud.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reports()
        {
            var charTypes = new List<ChartInfo>()
            {
                new ChartInfo() {Name = "Pastel", Value = "pie" },
                new ChartInfo() {Name = "Barras", Value = "bar" }
            };

            ViewBag.ChartTypes = charTypes;

            ViewBag.Title = "Reportes";
            ViewBag.Message = "Lista de reportes";

            return View();
        }

        public JsonResult GetDataCategories()
        {
            List<object> dataCategories = categoryService.
                GetCategories().
                Select(c => new
                {
                    name = c.Name,
                    quantity = c.Articles.Count
                }).
                Cast<object>().
                ToList();

            return Json(dataCategories, JsonRequestBehavior.AllowGet);
        }
    }
}