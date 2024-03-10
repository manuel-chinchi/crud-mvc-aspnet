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
        protected readonly IArticleService _articleService;
        protected readonly ICategoryService _categoryService;

        public BaseController()
        {
            _articleService = new ArticleService();
            _categoryService = new CategoryService();
        }

        #region Configure theme
        private static bool _defaultLightTheme { get; set; } = true;

        // Keys used for save values in Session
        public const string K_SWITCH_IS_ACTIVE = "SwitchIsActive";
        public const string K_THEME_ON = "ThemeOn";
        public const string K_THEME_OFF = "ThemeOff";

        // Paths of css file themes
        public const string FILE_THEME_LIGHT = "/Content/bootstrap.css";
        public const string FILE_THEME_DARK = "/Content/bootstrap-darkly.css";

        public string ThemeOn
        {
            get
            {
                return (string)Session[K_THEME_ON];
            }
            set
            {
                Session[K_THEME_ON] = value;
            }
        }

        public string ThemeOff
        {
            get
            {
                return (string)Session[K_THEME_OFF];
            }
            set
            {
                Session[K_THEME_OFF] = value;
            }
        }

        public bool SwitchIsActive
        {
            get
            {
                return (bool)Session[K_SWITCH_IS_ACTIVE];
            }
            set
            {
                Session[K_SWITCH_IS_ACTIVE] = value;
            }
        }

        [HttpPost]
        [Route(Name = "Base/ChangeAppTheme")]
        public JsonResult ChangeTheme(string themeOn, string themeOff, bool switchIsActive)
        {
            ThemeOn = themeOn;
            ThemeOff = themeOff;
            SwitchIsActive = switchIsActive;

            var data = new
            {
                themeOn = ThemeOn,
                themeOff = ThemeOff,
                switchIsActive = SwitchIsActive
            };

            return Json(data);
        }

        private List<string> ToList(dynamic dict)
        {
            var keys = new List<string>();
            foreach (string k in dict)
            {
                keys.Add(k);
            }
            return keys;
        } 

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var keys = new List<string>();
            keys = ToList(Session.Keys);

            //if (Session != null && Session.Keys.Count() == 0)
            if (!keys.Contains(K_THEME_ON) && !keys.Contains(K_THEME_ON) &&
                !keys.Contains(K_SWITCH_IS_ACTIVE))
            {
                ThemeOn = FILE_THEME_LIGHT;
                ThemeOff = FILE_THEME_DARK;
                SwitchIsActive = false;
            }

            if (_defaultLightTheme)
            {
                ViewBag.ThemeOn = ThemeOn;
                ViewBag.ThemeOff = ThemeOff;
                ViewBag.SwitchIsActive = SwitchIsActive;
            }
            else
            {
                ViewBag.ThemeOn = FILE_THEME_DARK;
                ViewBag.ThemeOff = FILE_THEME_LIGHT;
                ViewBag.SwitchIsActive = true;
                _defaultLightTheme = true;
            }
        }

        public void SetDefaultLightTheme(bool opt = true)
        {
            _defaultLightTheme = opt;
        }

        public void SetDefaultGlobalValues()
        {
            ViewBag.AppName = "crud_mvc_dotnet";
            ViewBag.AppVersion = "v1.2.1";
            ViewBag.AppTitle = ViewBag.AppName + " " + ViewBag.AppVersion + " (Proyecto)";
        }
        #endregion
    }
}