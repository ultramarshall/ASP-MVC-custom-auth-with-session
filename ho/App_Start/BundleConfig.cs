using System.Web;
using System.Web.Optimization;

namespace ho
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Assets/styles").Include(
                      "~/Assets/styles/webfont.css",
                      "~/Assets/styles/climacons-font.css",
                      "~/Assets/vendor/bootstrap/dist/css/bootstrap.css",
                      "~/Assets/styles/font-awesome.css",
                      "~/Assets/styles/card.css",
                      "~/Assets/styles/sli.css",
                      "~/Assets/styles/animate.css",
                      "~/Assets/styles/app.css",
                      "~/Assets/styles/app.skins.css"));

            bundles.Add(new ScriptBundle("~/Assets/scripts").Include(
                      "~/Assets/scripts/helpers/modernizr.js",
                      "~/Assets/vendor/jquery/dist/jquery.js",
                      "~/Assets/vendor/bootstrap/dist/js/bootstrap.js",
                      "~/Assets/vendor/fastclick/lib/fastclick.js",
                      "~/Assets/vendor/perfect-scrollbar/js/perfect-scrollbar.jquery.js",
                      "~/Assets/scripts/helpers/smartresize.js",
                      "~/Assets/scripts/constants.js",
                      "~/Assets/scripts/main.js"));

      

        }
    }
}
