using System.Collections.Generic;
using System.Threading.Tasks;

namespace KingICT.Academy.Model.Repositories
{
    public interface ICourseRepository
    {
        Task Create(Course course);
        Task<IEnumerable<Course>> GetAll();
    }
}
