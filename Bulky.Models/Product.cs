using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class Product
    {
        [Key] // This attribute indicates that this property is the primary key.
        public int Id { get; set; }

        [Required] // This attribute indicates that this property is required.
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [DisplayName("List Price")]
        [Range(1, 10000)]
        public double ListPrice { get; set; }

        //Cost of the product for quantity 1-50
        [Required]
        [DisplayName("Price for 1-50")]
        [Range(1, 10000)]
        public double Price { get; set; }

        //Cost of the product for quantity 50+
        [Required]
        [DisplayName("Price for 50+")]
        [Range(1, 10000)]
        public double Price50 { get; set; }

        //Cost of the product for quantity 100+
        [Required]
        [DisplayName("Price for 100+")]
        [Range(1, 10000)]
        public double Price100 { get; set; }

        public int CategoryId { get; set; } // Foreign key to the Category Table
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; } // Navigation property to the Category Table
        [ValidateNever]
        public string ImageUrl { get; set; } // URL for the product image
    }
}
