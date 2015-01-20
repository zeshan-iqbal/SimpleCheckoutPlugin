using Nop.Core.Plugins;
using Nop.Services.Common;
using System;
using System.Web.Routing;

namespace Nop.Plugin.Misc.SimpleCheckOut
{
    public class SimpleCheckoutPlugin : BasePlugin, IMiscPlugin
    {
        #region Methods
        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "MiscSimpleCheckout";
            routeValues = new RouteValueDictionary { { "Namespaces", "Nop.Plugin.Misc.SimpleCheckout.Controllers" }, { "area", null } };
        }
        #endregion
    }
}
