using System;
using System.Collections.Generic;
using System.Text;

namespace LuLibrary
{
    public class clsCourse
    {
        private string vNumber;
        private string vTitle;
        private Dictionary<String, clsStudent> vStudents;

        public clsCourse()
        {
            vNumber = vTitle = "Not defined";
            vStudents = new Dictionary<string, clsStudent>();
        }

        public clsCourse(string aNumber, string aTitle)
        {
            Number = aNumber;
            Title = aTitle;
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

        public string Display()
        {

            String info = "/nCourse Number:" + Number;
            info += "\nCourse Title" + Title;
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

        /// <summary>
        /// function that will find a student in the list of students 
        /// from this course else will return null
        /// </summary>
        public clsStudent FindStudent(String Number)
        {
            if (Students.ContainsKey(Number)) { 
                return Students[Number];
            }
            return null;
        }
    }
}