using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindShop.Model
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public DateTimeOffset Timestamp { get; set; }

        public Shop Shop { get; set; }
    }
}
