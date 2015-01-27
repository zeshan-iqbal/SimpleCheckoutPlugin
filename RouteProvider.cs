using Nop.Plugin.Misc.SimpleCheckout.Infrastructure;
using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nop.Plugin.Misc.SimpleCheckout
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            #region Register Custom ViewEngine
            ViewEngines.Engines.Insert(0, new CustomViewEngine());
            #endregion

            #region Register Routes
            //onepagecheckout
            routes.MapRoute("Plugin.Misc.SimpleCheckout.OnePageCheckout",
                "onepagecheckout/",
                new { controller = "MiscSimpleCheckout", action = "OnePageCheckout" },
                new[] { "Nop.Plugin.Misc.SimpleCheckout.Controllers" }
                );

            #endregion
        }

        public int Priority
        {
            get { return 1; }
        }
    }
}
