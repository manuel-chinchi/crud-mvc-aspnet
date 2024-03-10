using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class ReportController : BaseController
    {
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

        [HttpPost]
        [Route(Name = "/Report/GetDataCategories")]
        public JsonResult GetDataCategories()
        {
            List<object> dataCategories = _categoryService.
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