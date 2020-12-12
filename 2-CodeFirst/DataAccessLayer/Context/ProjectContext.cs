using _2_CodeFirst.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirst.DataAccessLayer.Context
{
    public class ProjectContext:DbContext // Implemented DbContext from entity framework
    {
        public ProjectContext()
        {   // MsSql windows authentication string on our localhost, gave "CodeFirstApproachDb" name to our Database.
            Database.Connection.ConnectionString = @"Server=localhost;Database=CodeFirstApproachDb;Integrated Security=True;";
        }

        // Make tables from our classes with DbSet
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
