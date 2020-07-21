using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KingICT.Academy.Model;
using KingICT.Academy.Model.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KingICT.Academy.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AcademyDbContext _context;

        public CourseRepository(AcademyDbContext context)
        {
            _context = context;
        }

        public async Task Create(Course course)
        {
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            return await _context.Courses.ToListAsync();
        }
    }
}
