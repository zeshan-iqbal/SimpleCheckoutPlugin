using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Web.Routing;

namespace Nop.Plugin.Misc.SimpleCheckOut
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            #region Example Routes
            /*
             //home page
            routes.MapRoute("Plugin.Misc.FacebookShop.Index",
                 "facebook/shop/",
                 new { controller = "MiscFacebookShop", action = "Index" },
                 new[] { "Nop.Plugin.Misc.FacebookShop.Controllers" }
            );

            //category page
            routes.MapRoute("Plugin.Misc.FacebookShop.Category",
                 "facebook/shop/category/{categoryId}/",
                 new { controller = "MiscFacebookShop", action = "Category" },
                 new { categoryId = @"\d+" },
                 new[] { "Nop.Plugin.Misc.FacebookShop.Controllers" }
            );

            //search page
            routes.MapRoute("Plugin.Misc.FacebookShop.ProductSearch",
                 "facebook/shop/search/",
                 new { controller = "MiscFacebookShop", action = "Search" },
                 new[] { "Nop.Plugin.Misc.FacebookShop.Controllers" }
            );
             */
            #endregion
        }

        public int Priority
        {
            get { return 0; }
        }
    }
}
