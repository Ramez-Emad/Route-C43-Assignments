using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Data.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Salary { get; set; }
        public string Address { get; set; } = null!;
        public int HourBounsRate { get; set; }
        public int Dept_ID { get; set; }
    }

}
