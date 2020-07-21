using KingICT.Academy.Messaging.Common;
using KingICT.Academy.Messaging.Student;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KingICT.Academy.Contract
{
    public interface IStudentService
    {


        Task<BasicResponse> Create(CreateStudentRequest student);

        Task<GetStudentsResponse> GetStudents();




    }
}
