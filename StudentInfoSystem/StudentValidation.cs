using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            Student student;
            if(user != null && user.FakNum != null)
            {
                student = (from s in new StudentInfoContext().Students
                               where s.FacNum.Equals(user.FakNum)
                               select s).DefaultIfEmpty(null).First() ?? throw new StudentNotFoundException("Student was not found");
            }
            else
            {
                throw new UserNotValidException("User data is not valid");
            }
            
            return student;
        }
    }
}
