﻿using System.Collections.Generic;
using Nop.Web.Framework.Mvc;
using Nop.Core.Domain.Common;

namespace Nop.Plugin.Misc.SimpleCheckout.Models
{
    public partial class CheckoutBillingAddressModel : BaseNopModel
    {
        public CheckoutBillingAddressModel()
        {
            ExistingAddresses = new List<AddressModel>();
            NewAddress = new AddressModel();
        }

        public IList<AddressModel> ExistingAddresses { get; set; }

        public AddressModel NewAddress { get; set; }

        /// <summary>
        /// Used on one-page checkout page
        /// </summary>
        public bool NewAddressPreselected { get; set; }
    }
}