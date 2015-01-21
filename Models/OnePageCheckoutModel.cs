using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.Misc.SimpleCheckOut.Models
{
    public partial class OnePageCheckoutModel : BaseNopModel
    {
        public bool ShippingRequired { get; set; }

        public bool DisableBillingAddressCheckoutStep { get; set; }
    }
}