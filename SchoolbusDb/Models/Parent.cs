using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolbusDb.Models
{
    public class Parent : BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public ICollection<Student>? Students { get; set; }
    }
}
