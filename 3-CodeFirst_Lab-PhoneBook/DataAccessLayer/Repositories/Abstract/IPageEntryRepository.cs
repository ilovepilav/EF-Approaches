using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Repositories.Abstract
{
    public interface IPageEntryRepository
    {
        void Add(string firstName, string lastName, string address, string country, string phoneNumber);
        void Update(int id, string firstName, string lastName, string address, string country, string phoneNumber);
    }
}
