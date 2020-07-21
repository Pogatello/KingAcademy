using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KingICT.Academy.Model.Repositories
{
    public interface IStudentRepository
    {



        Task Create(Student student);
        Task<IEnumerable<Student>> GetStudents();






    }
}
