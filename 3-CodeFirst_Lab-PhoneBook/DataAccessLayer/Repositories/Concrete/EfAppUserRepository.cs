using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Context;
using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Entities.Concrete;
using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Enums;
using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Repositories.Abstract;
using _3_CodeFirst_Lab_PhoneBook.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Repositories.Concrete
{
    public class EfAppUserRepository : IAppUserRepository,IBaseRepository<AppUser>
    {
        ProjectContext db;
        public EfAppUserRepository()
        {
            db = new ProjectContext();
        }

        public void Add(string firstName, string lastName, string userName, string password)
        {
            AppUser appUser = new AppUser();
            appUser.FirstName = firstName;
            appUser.LastName = lastName;
            appUser.UserName = userName;
            appUser.Password = password;
            db.AppUsers.Add(appUser);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            AppUser appUser = db.AppUsers.Where(x => x.Id == id).FirstOrDefault();
            appUser.Status = Status.Passive;
            appUser.DeletedDate = DateTime.Now;
            db.SaveChanges();
        }
        public void ChangePassword(int id, string password)
        {
            AppUser appUser = db.AppUsers.Where(x => x.Id == id).FirstOrDefault();
            appUser.Password = password;
            appUser.ModifiedDate = DateTime.Now;
            db.SaveChanges();
        }

        public List<AppUser> GetAll()
        {
            return db.AppUsers.ToList();
        }

        public AppUser GetById(int id)
        {
            return db.AppUsers.Where(x => x.Id == id).FirstOrDefault();
        }

        public AppUser GetByUsername(string userName)
        {
            return db.AppUsers.Where(x => x.UserName == userName).FirstOrDefault();
        }
    }
}
