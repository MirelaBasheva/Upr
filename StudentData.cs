using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentData
    {
        private static List<Student> _testStudents;

        public static List<Student> TestStudents
        {
            get
            {
                ResetTestStudentsData();
                return _testStudents;
            }
            set { }
        }

        static private void ResetTestStudentsData()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>(3);
                _testStudents.Add(new Student());
                _testStudents[0].name = "Tihomira";
                _testStudents[0].middleName = "Boykova";
                _testStudents[0].familyName = "Grosheva";
                _testStudents[0].faculty = "FKST";
                _testStudents[0].specialty = "KSI";
                _testStudents[0].educationalDegree = "Bachelor";
                _testStudents[0].status = "Unknown";
                _testStudents[0].facultyNumber = "121219112";
                _testStudents[0].course = 3;
                _testStudents[0].stream = 9;
                _testStudents[0].group = 32;

                _testStudents.Add(new Student());
                _testStudents[1].name = "Elena";
                _testStudents[1].middleName = "Mitkova";
                _testStudents[1].familyName = "Georgieva";
                _testStudents[1].faculty = "FKST";
                _testStudents[1].specialty = "KSI";
                _testStudents[1].educationalDegree = "Bachelor";
                _testStudents[1].status = "Unknown";
                _testStudents[1].facultyNumber = "121219005";
                _testStudents[1].course = 3;
                _testStudents[1].stream = 9;
                _testStudents[1].group = 31;

                _testStudents.Add(new Student());
                _testStudents[2].name = "Ivan";
                _testStudents[2].middleName = "Ivanov";
                _testStudents[2].familyName = "Petkov";
                _testStudents[2].faculty = "FKST";
                _testStudents[2].specialty = "KSI";
                _testStudents[2].educationalDegree = "Bachelor";
                _testStudents[2].status = "Unknown";
                _testStudents[2].facultyNumber = "121219120";
                _testStudents[2].course = 3;
                _testStudents[2].stream = 9;
                _testStudents[2].group = 32;


            }

        }
    }
}
