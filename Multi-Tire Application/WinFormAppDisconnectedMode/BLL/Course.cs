using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAppDisconnectedMode.DAL;

namespace WinFormAppDisconnectedMode.BLL
{
    public class Course
    {
        private string courseCode;
        private string courseTitle;
        private int totalHour;

        public string CourseCode { get => courseCode; set => courseCode = value; }
        public string CourseTitle { get => courseTitle; set => courseTitle = value; }
        public int TotalHour { get => totalHour; set => totalHour = value; }

        public List<Course> ListCourses()
        {
            return CourseDB.GetRecordList();
        }
    }

    
}
