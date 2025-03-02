using EF_01.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Data.Models.Configurations
{
    internal class Stud_CourseConfigurations : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.HasKey(e => new { e.Stud_id, e.Course_id });
            builder.Property(e => e.Grade).HasDefaultValue(0);
        }
    }
}
