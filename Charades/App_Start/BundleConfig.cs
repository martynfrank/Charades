using System.Web.Optimization;

namespace Charades.App_Start
{
    public class BundleConfig
    {
        public static void Start(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Core").Include(
                "~/Scripts/jquery-2.1.1.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/knockout-3.1.0.js",
                "~/Scripts/Play/*.js"));

            bundles.Add(new StyleBundle("~/Content/Styles").Include(
                 "~/Content/bootstrap.css",
                 "~/Content/Site.css"));
        }
    }
}