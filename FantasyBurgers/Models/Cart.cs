/*
 * This class represents the model of shopping cart
 * Filename: Cart.cs
 * Modified date: 12/16/2016
 * Website: http://comp229-fantasy-burgers.azurewebsites.net/
 * Authors:
 *      - Eddie Song
 *      - Waynnel Lovelll
 *      - Thiago de Andrade
 *      - Sahil Mahajan
 *      - Anmol Sharma
 */
namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int RecordId { get; set; }

        [Required]
        public string CartId { get; set; }

        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
