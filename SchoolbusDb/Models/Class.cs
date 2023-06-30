using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolbusDb.Models
{
    public class Class : BaseEntity
    {
        public string Name { get; set; } = null!;

        public ICollection<Student>? Students { get; set; }
    }
}
