using _2_CodeFirst.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CodeFirst.EntityLayer.Entities.Abstract
{
    public class BaseEntity
    {
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Even if we don't declare it with Data annotations Entity framework will make this property as identity because we named it as "Id"
        public int Id { get; set; }
        private DateTime _createDate = DateTime.Now; // Timestamp it as we create

        public DateTime CreateDate { get => _createDate; } // We don't need set here.
        public DateTime? ModifiedTime { get; set; } // Make it nullable, only need it when we use it.
        public DateTime? DeletedDate { get; set; } // Nullable too
        private Status _status = Status.Active; // Make it active when it created

        public Status Status { get => _status; set => _status = value; }


    }
}
