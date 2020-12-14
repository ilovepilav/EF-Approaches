using _3_CodeFirst_Lab_PhoneBook.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Repositories.Abstract
{
    interface IAppUserRepository
    {        
        void Add(string firstName, string lastName, string userName, string password);
        void ChangePassword(int id, string password);
        AppUser GetByUsername(string userName);


    }
}
