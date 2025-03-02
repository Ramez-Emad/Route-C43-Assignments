using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Data.Models
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Duration { get; set; }

        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength( 50 ,ErrorMessage = "Description must be less than 50 characters")]
        public string? Description { get; set; }

        public int Top_id { get; set; }
    
    }
}
