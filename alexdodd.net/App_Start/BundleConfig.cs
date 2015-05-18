using System;
using System.Web.Optimization;

namespace alexdodd.net
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/App.js"));

            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                     "~/Content/Styles.min.css"));

            bundles.Add(new StyleBundle("~/bundles/CV").Include("~/Content/CV.min.css"));
        }
    }
}