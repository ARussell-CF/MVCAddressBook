using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAddressBook.Models
{
    public class Category
    {
        //Primary key
        public int Id { get; set; }

        //Foreign key
        public string UserId { get; set; }

        public string Name { get; set; }

        public virtual AppUser User { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
    }
}
