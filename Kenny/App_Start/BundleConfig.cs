using System.Web.Optimization;

namespace Kenny
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            AddJavaScriptLibraries(bundles);
            AddStyleSheetLibraries(bundles);
        }

        private static void AddJavaScriptLibraries(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/MDL").Include(
                "~/Scripts/Plugins/MDL/material.min.js"));
        }

        private static void AddStyleSheetLibraries(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/App").Include(
                "~/Content/App/animation.css",
                 "~/Content/Plugins/MDL/styles.css",
                "~/Content/Plugins/MDL/material.grey-orange.min.css"));
        }
    }
}
