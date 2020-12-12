using _2_CodeFirst.EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirst.EntityLayer.Entities.Concrete
{
    public class Product:BaseEntity
    {
        [Required, MaxLength(100, ErrorMessage = "Product name can't be more than 100 characters long"), MinLength(3, ErrorMessage = "Product name can't be less than 3 characters.")]
        public string ProductName { get; set; }
        [ForeignKey("Category")] // Defined CategoryId as foreignkey
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } // One to many relationship with products table
    }
}
