using System.Web.Optimization;

namespace Web
{
  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
      BundleTable.EnableOptimizations = true;
    }
  }
}
