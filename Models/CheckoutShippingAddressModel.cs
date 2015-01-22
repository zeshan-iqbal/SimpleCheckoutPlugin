using System.Collections.Generic;
using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.Misc.SimpleCheckOut.Models
{
    public partial class CheckoutShippingAddressModel : BaseNopModel
    {
        public CheckoutShippingAddressModel()
        {
            ExistingAddresses = new List<AddressModel>();
            NewAddress = new AddressModel();
        }

        public IList<AddressModel> ExistingAddresses { get; set; }

        public AddressModel NewAddress { get; set; }

        public bool NewAddressPreselected { get; set; }

        public bool AllowPickUpInStore { get; set; }
        public string PickUpInStoreFee { get; set; }
        public bool PickUpInStore { get; set; }
    }
}