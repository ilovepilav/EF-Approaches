using _2_CodeFirst.EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirst.EntityLayer.Entities.Concrete
{
    public class Category:BaseEntity
    {
        [Required,MaxLength(100,ErrorMessage ="Category name can't be more than 100 characters long"),MinLength(3,ErrorMessage = "Category name can't be less than 3 characters.")] //Defined character lengths
        public string CategoryName { get; set; }
        [Required, StringLength(300,ErrorMessage ="Description can't be more than 300 characters long")] // Defined max character length witn StringLength
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; } // Relationship with Products table (One to many)
    }
}
