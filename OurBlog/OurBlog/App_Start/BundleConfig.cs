using System.Web;
using System.Web.Optimization;

namespace OurBlog
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/easyui").Include(
                      "~/Scripts/jquery-easyui-1.4.5/jquery-{version}.js",
                      "~/Scripts/jquery-easyui-1.4.5/jquery.easyui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/SelfDefineJS").Include(
                      "~/Scripts/self_scripts/SelfDefineJS.js"));

            bundles.Add(new ScriptBundle("~/bundles/SelfDefineJS").Include(
                      "~/Scripts/self_scripts/SelfDefineJS.js"));

            bundles.Add(new StyleBundle("~/Styles/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Styles/login").Include(
                      "~/Content/login.css"));
        }
    }
}
