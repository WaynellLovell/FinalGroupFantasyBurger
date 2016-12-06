namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drink
    {
        public int DrinkId { get; set; }

        [Required]
        public string DrinkName { get; set; }

        [Required]
        [StringLength(50)]
        public string DrinkShortDescription { get; set; }

        public string DrinkLongDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DrinkPrice { get; set; }

        public string DrinkImage { get; set; }
    }
}
