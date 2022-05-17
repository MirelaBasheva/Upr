using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        public Student GetStudentDataByUser(User u)  
        {
            foreach (Student s in StudentData.TestStudents)
            {
                if (s.facultyNumber != null || s.facultyNumber == u.FacNum)
                    return s;
            }
            Console.WriteLine("Could not find faculty number");
            return null;
        }
    }
}
