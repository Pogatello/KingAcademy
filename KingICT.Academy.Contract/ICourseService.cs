using System.Threading.Tasks;
using KingICT.Academy.Messaging.Common;
using KingICT.Academy.Messaging.Course;

namespace KingICT.Academy.Contract
{
    public interface ICourseService
    {
        Task<BasicResponse> Create(CreateCourseRequest request);

        Task<GetCoursesResponse> GetAll(BasicRequest request);
    }
}
