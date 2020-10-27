using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
