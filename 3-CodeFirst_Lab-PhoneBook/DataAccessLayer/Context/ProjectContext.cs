using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Entities.Concrete;
using _3_CodeFirst_Lab_PhoneBook.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString= @"Server=localhost;Database=PhoneBookDb;Integrated Security=True;";
        }

        public DbSet<PageEntry> PageEntries { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
