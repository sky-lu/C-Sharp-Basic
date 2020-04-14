using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsClassAndCollection
{
    class clsStudent
    {
        private String vName;
        private String vTelephone;
        private Single vGrade;
        
        public clsStudent(String aName, String aTel, Single aGrade)
        {
            Name = aName;
            Telephone = aTel;
            Grade = aGrade;
        }
        
        public string Name { get => vName; set => vName = value; }
        public string Telephone { get => vTelephone; set => vTelephone = value; }
        public Single Grade { get => vGrade; set => vGrade = value; }

        public String Display()
        {
            String info;
            info = " Name: " + vName + " \nTelephone: " + vTelephone + " \nGrade: " + vGrade;
            return info;
        }
    }
}
