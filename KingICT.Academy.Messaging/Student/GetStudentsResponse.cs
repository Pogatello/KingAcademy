using KingICT.Academy.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingICT.Academy.Messaging.Student
{
    public class GetStudentsResponse : ResponseBase
    {
        public IEnumerable<StudentDto> Students { get; set; }



    }
}
