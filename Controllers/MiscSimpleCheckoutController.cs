using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Plugin.Misc.SimpleCheckout.Controllers
{
    public class MiscSimpleCheckoutController : BasePluginController
    {
        #region Fields
        #endregion

        #region ctor
        #endregion

        #region Utilities
        #endregion

        #region Methods
        [ChildActionOnly]
        [AdminAuthorize]
        public ActionResult Configure()
        {
            return View("~/Plugins/Misc.SimpleCheckout/Views/MiscSimpleCheckout/Configure.cshtml");
        }
        #endregion
    }
}
