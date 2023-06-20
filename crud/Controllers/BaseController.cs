using crud.Services;
using crud.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class BaseController : Controller
    {
        protected IArticleService articleService { get; set; }
        protected ICategoryService categoryService { get; set; }

        public BaseController()
        {
            articleService = new ArticleService();
            categoryService = new CategoryService();
        }
    }
}