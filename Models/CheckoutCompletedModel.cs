using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.Misc.SimpleCheckOut.Models
{
    public partial class CheckoutCompletedModel : BaseNopModel
    {
        public int OrderId { get; set; }
        public bool OnePageCheckoutEnabled { get; set; }
    }
}