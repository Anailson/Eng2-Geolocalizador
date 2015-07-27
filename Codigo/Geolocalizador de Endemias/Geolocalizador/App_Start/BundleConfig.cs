using System.Web;
using System.Web.Optimization;

namespace Geolocalizador.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/js/jquery-{version}.js"));


            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                      "~/Content/js/materialize.js",
                      "~/Content/js/materialize.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/materialize.css",
                      "~/Content/css/materialize.min.css"));
        }
    }
}
