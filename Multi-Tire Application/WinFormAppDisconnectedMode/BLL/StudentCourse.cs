using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAppDisconnectedMode.DAL;

namespace WinFormAppDisconnectedMode.BLL
{
    class StudentCourse
    {
        private int studentId;
        private string courseCode;
        private DateTime registrationDate;
        private DateTime startingDate;
        private DateTime endingDate;

        public int StudentId { get => studentId; set => studentId = value; }
        public string CourseCode { get => courseCode; set => courseCode = value; }
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }
        public DateTime StartingDate { get => startingDate; set => startingDate = value; }
        public DateTime EndingDate { get => endingDate; set => endingDate = value; }

        public List<Course> GetCourseByStudent (Int32 studId)
        {
            List<string> lstCode = StudentCourseDB.GetCourseCodeList(studId);
            return StudentCourseDB.GetCourseList(lstCode);
        }

        public List<Student> GetStudentByCourse (string code)
        {
            List<int> lstId = StudentCourseDB.GetStudIdList(code);
            return StudentCourseDB.GetStudentList(lstId);
        }
    }
}
