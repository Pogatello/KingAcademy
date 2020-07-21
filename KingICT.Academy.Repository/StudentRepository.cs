using KingICT.Academy.Model;
using KingICT.Academy.Model.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KingICT.Academy.Repository
{
    public class StudentRepository : IStudentRepository
    {

        private readonly AcademyDbContext _context;

        public StudentRepository(AcademyDbContext context)
        {
            _context = context;
        }

        public async Task Create(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
