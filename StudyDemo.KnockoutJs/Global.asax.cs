using StudyDemo.Framework.Knockout;
using StudyDemo.KnockoutJs.Resolver;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StudyDemo.KnockoutJs
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyResolver.SetResolver(new UnityResolver(Container.InitUnityContainer()));
            ModelBinders.Binders.DefaultBinder = new KnockoutModelBinder();
        }
    }
}
