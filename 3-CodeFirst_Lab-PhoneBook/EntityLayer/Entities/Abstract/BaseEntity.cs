using _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirst_Lab_PhoneBook.DataAccessLayer.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        private DateTime _createDate = DateTime.Now;

        public DateTime CreateDate { get => _createDate; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }

    }
}
