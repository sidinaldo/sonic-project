using System.Web;
using System.Web.Optimization;

namespace ProjetoSonic.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/perfect-scrollbar.min.js",
                        "~/Scripts/plugins.js"));            

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.unobtrusive*"));
            
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/main-style.css",
                      "~/Content/style.css"));

            bundles.Add(new StyleBundle("~/Content/pagecenter").Include(
                     "~/Content/page-center.css"
                     ));

            bundles.Add(new StyleBundle("~/Content/materialize").Include(
                      "~/Content/materialize.css",
                      "~/Content/style.css",
                      "~/Content/principal.css",
                      "~/Content/font-awesome.css",
                      "~/Content/jquery.dataTables.min.css",
                      "~/Contente/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                     "~/Scripts/materialize.js",
                     "~/Scripts/jquery.dataTables.min.js",
                     "~/Scripts/data-tables-script.js"));


            bundles.Add(new StyleBundle("~/Content/Principal").Include(
                     "~/Content/assets/css/main-styles.css",
                     "~/Content/assets/css/style.css",
                    "~/Content/assets/font-awesome/css/font-awesome.css",
                    "~/Content/assets/font-awesome/css/font-awesome.min.css",
                    "~/Content/assets/plugins/dataTables/dataTables.bootstrp.css",
                    "~/Content/assets/plugins/morris/morris-0.4.3.min.css",
                    "~/Content/assets/plugins/bootstrap/bootstrap.css",
                    "~/Content/assets/plugins/pace/pace-theme-big-counter.css",
                    "~/Content/assets/plugins/social-buttons/social-buttons.css",
                    "~/Content/assets/plugins/timeline/timeline.css"));

            bundles.Add(new ScriptBundle("~/bundles/Principal").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/perfect-scrollbar.min.js",
                        "~/Scripts/plugins.js"));



        }
    }
}
