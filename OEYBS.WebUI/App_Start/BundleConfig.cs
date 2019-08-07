using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace OEYBS.WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // ## Css - StyleBundle

            // Home

            // SystemAdministrator
            bundles.Add(new StyleBundle("~/systemadministrator/css/base").Include(
               "~/Themes/sb2/css/sb-admin-2.min.css",
               "~/Themes/sb2/vendor/datatables/dataTables.bootstrap4.min.css"
               ).Include("~/Themes/sb2/vendor/fontawesome-free/css/all.min.css", new CssRewriteUrlTransform()));



            // ## JS- ScriptBundle

            // Home



            // SystemAdministrator
            bundles.Add(new ScriptBundle("~/systemadministrator/js/base").Include(
                "~/Themes/sb2/vendor/jquery/jquery.min.js",
                "~/Themes/sb2/vendor/bootstrap/js/bootstrap.bundle.min.js",
                "~/Themes/sb2/vendor/jquery-easing/jquery.easing.min.js",
                "~/Themes/sb2/js/sb-admin-2.min.js"
                ));

            bundles.Add(new ScriptBundle("~/systemadministrator/js/dataTable").Include(
                "~/Themes/sb2/vendor/datatables/jquery.dataTables.min.js",
                "~/Themes/sb2/vendor/datatables/dataTables.bootstrap4.min.js"
                ));

            bundles.Add(new ScriptBundle("~/systemadministrator/js/jqvalidate").Include(
               "~/Scripts/jquery.validate.min.js",
               "~/Scripts/jquery.validate.unobtrusive.min.js"
               ));



            BundleTable.EnableOptimizations = true;
        }
    }
}