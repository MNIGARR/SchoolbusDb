using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolbusDb.Models
{
    public class Car : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string CarNumber { get; set; } = null!;

        public int SeatCount { get; set; }

        public Driver? Driver { get; set; }
    }
}
