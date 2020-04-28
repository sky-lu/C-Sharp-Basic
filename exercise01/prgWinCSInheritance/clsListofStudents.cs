using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgWinCSInheritance
{
    class clsListofStudents
    {
        private List<clsStudent> myList = new List<clsStudent>();
        
        public Int32 NumberOfStudents
        {
            get
            {
                return myList.Count;
            }
        }

        public bool Add(clsStudent student)
        {
            if(myList.Contains(student) == false)
            {
                myList.Add(student);
                return true;
            }
            return false;
        }

        public string Display()
        {
            string info = "\nAll the students of the class\n";
            foreach (clsStudent st in myList)
            {
                info += st.Display();
            }
            return info;
        }
    }
}
