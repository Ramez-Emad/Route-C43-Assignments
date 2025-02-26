﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Data.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public string? Address { get; set; }
        public int Age { get; set; }
        public int Dep_id { get; set; }
    }
}
