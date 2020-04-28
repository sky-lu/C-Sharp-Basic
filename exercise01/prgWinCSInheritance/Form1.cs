using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgWinCSInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clsPerson person = new clsPerson("C001","Honglin", "1234567890");
            //MessageBox.Show(person.ToString());
            //clsTeacher myFavoriteTeacher = new clsTeacher("23", "Fode", "911", 200000);
            //MessageBox.Show(myFavoriteTeacher.Display());

            clsListofStudents tabStuds = new clsListofStudents();
            clsStudent st1 = new clsStudent("C001", "Honglin", "1234567890", 90);
            tabStuds.Add(st1);
            MessageBox.Show(tabStuds.NumberOfStudents.ToString());
        }
    }
}
