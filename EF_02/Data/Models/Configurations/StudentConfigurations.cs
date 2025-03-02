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
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.LName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Address)
                .HasMaxLength(100);

            builder.Property(e => e.Age)
                .IsRequired();

            builder.Property(e => e.Dep_id)
                .IsRequired();
            
        }
    }
}
