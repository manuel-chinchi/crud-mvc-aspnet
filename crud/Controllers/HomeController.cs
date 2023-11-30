using System;
using System.Collections.Generic;
using System.Data;
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
            return View();
        }

        public JsonResult GetDataCategories()
        {
            // implicit casting
            //var dataCategories = categoryService.GetCategories().Select(c => new { name = c.Name, quantity = c.Articles.Count }).ToList();
            // explicit casting
            List<object> dataCategories = categoryService.GetCategories().
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