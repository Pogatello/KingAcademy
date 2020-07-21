using KingICT.Academy.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingICT.Academy.Repository.Configurations
{
    class StudentConfiguration : IEntityTypeConfiguration<Student>
    {

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable(nameof(Student));
            builder.HasKey(k => k.Id);
            builder.Property(prop => prop.Id).ValueGeneratedOnAdd();



            builder.Property(p => p.FirstName)
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(p => p.LastName)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(p => p.BirthDate).IsRequired();
        }
    }
}
