using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Entities.Abstract;
using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Entities.Concrete;
using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_Lab_PhoneBook.EntityLayer.Entities.Concrete
{
    public class AppUser:BaseEntity
    {
        [Required,MaxLength(15)]
        public string FirstName { get; set; }
        [Required, MaxLength(15)]
        public string LastName { get; set; }
        [Required, MaxLength(15)]
        public string UserName { get; set; }
        [Required, MaxLength(15)]
        public string Password { get; set; }
        public Role Role { get; set; }
        public virtual List<PageEntry> PageEntries { get; set; }
    }
}
