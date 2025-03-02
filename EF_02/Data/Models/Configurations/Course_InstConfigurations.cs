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
    internal class Course_InstConfigurations : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.ToTable("Course_Inst", "dbo")
                   .HasKey(ci => new { ci.Course_id, ci.Ins_id })
                   .HasName("PK_Course_Inst_Course_id_Ins_id");

            builder.Property(ci => ci.Evaluate)
                    .HasColumnName("Evaluate")
                    .HasColumnType("int")
                    .IsRequired();        
        }
    }
}
