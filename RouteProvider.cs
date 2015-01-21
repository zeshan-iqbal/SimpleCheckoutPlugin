using Nop.Plugin.Misc.SimpleCheckOut.Infrastructure;
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
            routes.MapRoute("Plugin.Misc.SimpleCheckout.OnePageCheckout",
                "onepagecheckout",
                new { controller = "MiscSimpleCheckout", action = "OnePageCheckout" },
                new[] { "Nop.Plugin.Misc.SimpleCheckout.Controllers" }
                );
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
