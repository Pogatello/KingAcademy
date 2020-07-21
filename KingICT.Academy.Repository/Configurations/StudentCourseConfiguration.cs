using KingICT.Academy.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingICT.Academy.Repository.Configurations
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.ToTable(nameof(StudentCourse));
            builder.HasKey(k => new { k.StudentId, k.CourseId});

            builder.HasOne(b => b.Student).WithMany(s => s.StudentCourses).HasForeignKey(sc => sc.StudentId);
            builder.HasOne(c => c.Course).WithMany(c => c.StudentCourses).HasForeignKey(sc => sc.CourseId);
        }
    }
}
