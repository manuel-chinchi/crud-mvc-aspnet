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
                //"~/Scripts/umd/popper.js",
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // El archivo jquery.dataTables.min.css no viene junto al paquete Nugget
            // de la solución, se instala aparte desde https://cdn.datatables.net/1.13.4/css/jquery.dataTables.css
            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                    "~/Content/jquery.dataTables.min.css",
                    "~/Content/datatables-custom.css"
                ));

            // El archivo buttons.dataTables.min.css no viene en el paquete Nugget "datatables buttons"
            // se instala aparte desde https://cdn.datatables.net/buttons/2.4.2/css/buttons.dataTables.min.css
            bundles.Add(new StyleBundle("~/Content/datatables-buttons").Include(
                    "~/Content/buttons.dataTables.min.css",
                    "~/Content/datatables-buttons-custom.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/datatables-articles").Include(
                    "~/Scripts/jquery.dataTables.min.js",
                    "~/Scripts/datatables-config-articles.js",
                    "~/Scripts/datatables-custom.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/datatables-categories").Include(
                    "~/Scripts/jquery.dataTables.min.js",
                    "~/Scripts/datatables-config-categories.js",
                    "~/Scripts/datatables-custom.js"
                ));

            // Los archivos jszip.min.jq, pdfmake.min.js y vfs_fonts.js no vienen en el paquete Nugget "datatables buttons"
            // se descargan aparte desde 
            // https://cdnjs.cloudflare.com/ajax/libs/jszip/3.10.1/jszip.min.js
            // https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js
            // https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js
            bundles.Add(new ScriptBundle("~/bundles/datatables-buttons").Include(
                    "~/Scripts/dataTables.buttons.js",
                    // button excel
                    "~/Scripts/jszip.min.js",
                    // button pdf
                    "~/Scripts/pdfmake.min.js",
                    "~/Scripts/vfs_fonts.js",
                    // other buttons
                    //"~/Scripts/buttons.flash.min.js",
                    //"~/Scripts/buttons.colVis.min.js",
                    "~/Scripts/buttons.html5.min.js",
                    "~/Scripts/buttons.print.min.js"
                ));

            bundles.Add(new Bundle("~/bundles/chartjs").Include(
                "~/Scripts/chart.min.js",
                "~/Scripts/chartjs-custom.js",
                "~/Scripts/chartjs-config.js"
                ));

            bundles.Add(new StyleBundle("~/bundles/chartjs-custom").Include(
                "~/Content/chartjs-custom.css"
                ));
        }
    }
}
