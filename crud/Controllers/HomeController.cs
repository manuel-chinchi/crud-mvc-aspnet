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
            var data = new ViewDataDictionary()
            {
                { "urlJquery", "https://jquery.com/" },
                { "urlBootstrap", "https://getbootstrap.com/" },
                { "urlDatatables", "https://datatables.net/"},
                { "urlEF6", "https://www.nuget.org/packages/EntityFramework/" },
                { "urlChartjs", "https://www.chartjs.org/" },
                { "urlJszip", "https://stuk.github.io/jszip/" },
                { "urlPdfmake", "http://pdfmake.org/#/" },
                { "title", "Información del proyecto" },
                { "message", "Sistema CRUD hecho en C# ASP.NET" },
                { "repository", "https://github.com/manuel-chinchi/crud-mvc-aspnet"  }
            };

            return View(data);
        }
    }
}