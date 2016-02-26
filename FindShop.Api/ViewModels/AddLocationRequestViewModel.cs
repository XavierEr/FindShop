using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindShop.Api.ViewModels
{
    public class AddLocationRequestViewModel
    {
        public string Address { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}