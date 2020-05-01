using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermCT2HonglinLu
{
    class clsCourse
    {
        private string vNumber;
        private string vTitle;
        private string vTeacher;
        private Int16 vDuration;
        private Dictionary<String, clsStudent> vStudents;

        public clsCourse()
        {
            vNumber = vTitle = vTeacher =  "Not defined";
            vDuration = 0;
            vStudents = new Dictionary<string, clsStudent>();
        }

        public clsCourse(string aNumber, string aTitle, string aTeacher, Int16 aDuration)
        {
            Number = aNumber;
            Title = aTitle;
            Teacher = aTeacher;
            Duration = aDuration;
            Students = new Dictionary<string, clsStudent>();
        }

        public string Number
        {
            get => vNumber;
            set
            {
                vNumber = value;
            }
        }

        public string Title
        {
            get => vTitle;
            set
            {
                vTitle = value;
            }
        }

        public Dictionary<String, clsStudent> Students
        {
            get => vStudents;
            set
            {
                vStudents = value;
            }
        }

        public string Teacher { get => vTeacher; set => vTeacher = value; }
        public short Duration { get => vDuration; set => vDuration = value; }

        public string Display()
        {

            String info = "/nCourse Number:" + Number;
            info += "\nCourse Title:" + Title;
            info += "\nCourse Teacher:" + Teacher;
            info += "\nCourse Duration:" + Duration;
            info += "\nThe students of the course: \n";
            foreach (clsStudent st in Students.Values)
            {
                info += st.Display();
            }
            return info;
        }

        public bool AddStudent(clsStudent aStudent)
        {
            if (!Students.ContainsKey(aStudent.Number))
            {
                Students.Add(aStudent.Number, aStudent);
                return true;
            }
            return false;
        }

        
        public clsStudent FindStudent(String Number)
        {
            if (Students.ContainsKey(Number))
            {
                return Students[Number];
            }
            return null;
        }

        public bool DeleteStudent(clsStudent aStudent)
        {
            if (!Students.ContainsKey(aStudent.Number))
            {
                Students.Remove(aStudent.Number);
                return true;
            }
            return false;
        }
    }
}
