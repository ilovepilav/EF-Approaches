using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Repositories.Abstract
{
    public  interface IBaseRepository<T>
    {
        void Delete(int id);
        T GetById(int id);
        List<T> GetAll();
    }
}
