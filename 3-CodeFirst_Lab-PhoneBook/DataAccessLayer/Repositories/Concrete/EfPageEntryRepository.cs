using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Context;
using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Entities.Concrete;
using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Enums;
using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Repositories.Concrete
{
    public class EfPageEntryRepository : IBaseRepository<PageEntry>, IPageEntryRepository
    {
        ProjectContext db;
        public EfPageEntryRepository()
        {
            db = new ProjectContext();
        }
        public void Add(string firstName, string lastName, string address, string country, string phoneNumber)
        {
            PageEntry pageEntry = new PageEntry();
            pageEntry.FirstName = firstName;
            pageEntry.LastName = lastName;
            pageEntry.Address = address;
            pageEntry.Country = country;
            pageEntry.PhoneNumber = phoneNumber;
            db.PageEntries.Add(pageEntry);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            PageEntry pageEntry = db.PageEntries.Where(x => x.Id == id).FirstOrDefault();
            pageEntry.Status = Status.Passive;
            pageEntry.DeletedDate = DateTime.Now;
            db.SaveChanges();
        }

        public List<PageEntry> GetAll()
        {
            return db.PageEntries.ToList();
        }

        public PageEntry GetById(int id)
        {
            return db.PageEntries.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(int id,string firstName, string lastName, string address, string country, string phoneNumber)
        {
            PageEntry pageEntry = db.PageEntries.Where(x => x.Id == id).FirstOrDefault();
            pageEntry.FirstName = firstName;
            pageEntry.LastName = lastName;
            pageEntry.Address = address;
            pageEntry.Country = country;
            pageEntry.PhoneNumber = phoneNumber;
            pageEntry.Status = Status.Modified;
            pageEntry.ModifiedDate = DateTime.Now;
            db.PageEntries.Add(pageEntry);
            db.SaveChanges();
        }
    }
}
