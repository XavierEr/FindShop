using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindShop.Model
{
    public class Shop
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Location> Locations { get; set; }
    }
}
