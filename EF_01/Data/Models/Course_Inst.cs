using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Data.Models
{
    internal class Course_Inst
    {
        public int Id { get; set; } // to avoid the error: "The entity type requires a primary key to be defined."

        public int Course_id { get; set; }
        public int Ins_id { get; set; }
        public int Evaluate { get; set; }
    }
}
