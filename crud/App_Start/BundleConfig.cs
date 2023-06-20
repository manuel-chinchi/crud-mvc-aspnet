using System.Web;
using System.Web.Optimization;

namespace crud
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // El archivo jquery.dataTables.min.css no viene junto al paquete Nugget
            // de la solución, se instala aparte desde https://cdn.datatables.net/1.13.4/css/jquery.dataTables.css
            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                    "~/Content/jquery.dataTables.min.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                    "~/Scripts/datatables-custom.js",
                    "~/Scripts/jquery.dataTables.min.js"
                ));
        }
    }
}
