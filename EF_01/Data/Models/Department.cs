using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Data.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Ins_ID { get; set; }
        public DateOnly HirringDate { get; set; }
    }
}
