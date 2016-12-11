namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    /*Author's name: Waynell Lovell,
               Thiago De Andrade Souza,
               Edward Song,
               Sahil Mahajan,
               Anmol .
Date Created: November 30th, 2016
Version History: Part-1.Project Concept, Landing Page &	Site Security,
                 Part-2.Main Functionality & Database Connectivity,
                 Part-3.Finished Version � Fully Styled and Functional
File Description: Takes the cart information of the user, and carries it to the page, so they can order.  */
    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        [StringLength(256)]
        public string Username { get; set; }

        [Required(ErrorMessage ="First Name is required")]
        [StringLength(160)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(40)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email Address is required")]

        [StringLength(160)]

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",

            ErrorMessage = "Email is is not valid.")]

        [DataType(DataType.EmailAddress)]

        [DisplayName("Email Address")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
