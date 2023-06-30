using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolbusDb.Models
{
    public class Ride : BaseEntity
    {
        public int DriverId { get; set; }

        public Driver? Driver { get; set; }

        public ICollection<Student>? Students { get; set; }
    }
}
