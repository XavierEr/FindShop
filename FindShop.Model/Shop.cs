using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindShop.Model
{
    public class Shop
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
