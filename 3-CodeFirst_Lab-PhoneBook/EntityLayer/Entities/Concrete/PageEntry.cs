using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Entities.Abstract;
using _3_CodeFirst_Lab_PhoneBook.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Entities.Concrete
{
    public class PageEntry:BaseEntity
    {
        [Required, MaxLength(15), MinLength(3)]
        public string FirstName { get; set; }
        [Required, MaxLength(15), MinLength(3)]
        public string LastName { get; set; }
        [Required, MaxLength(255), MinLength(20)]
        public string Address { get; set; }
        [Required, MaxLength(55), MinLength(3)]
        public string Country { get; set; }
        [Required, MaxLength(10), MinLength(10)]
        public string PhoneNumber { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
