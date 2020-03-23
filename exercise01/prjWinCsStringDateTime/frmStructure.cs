using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsStringDateTime
{
    public partial class frmStructure : Form
    {
        public frmStructure()
        {
            InitializeComponent();
        }


        struct Student
        {
            public String Name;
            public Single Grade;
            public String Number;
        }
        Student[] listStuds = new Student[20];
        Int16 i ;
        //Int32 n = 0;
        private void frmStructure_Load(object sender, EventArgs e)
        {
            i = 0;

        }
        private bool Exist (String number)
        // Check if the student already exists
        {
            foreach(Student st in listStuds)
            {
                if(st.Number == number)
                {
                    return true;
                }
            }
            return false;
        }

        private Student? Find(String Number)//check the meaning!!!!
        {
            foreach(Student st in listStuds)
            {
                if(st.Number == Number)
                {
                    return st;
                }
            }
            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //if (i < 20)
            //{
            //    String number = txtNumber.Text.Trim();
            //    String name = txtName.Text.Trim();
            //    Single grade = Convert.ToSingle(txtGrade.Text);
            //    listStuds[i].Number = number;
            //    listStuds[i].Name = name;
            //    listStuds[i].Grade = grade;

            //    lstNumbers.Items.Add(number);
            //    txtNumber.Text = txtName.Text = txtGrade.Text = "";
            //    txtNumber.Focus();
            //    //txtNumber.Clear();
            //    //txtName.Clear();
            //    //txtGrade.Clear();
            //    i = i + 1;
            //}
           
            if(i < 20) { 
                // You should check if the number is over the size of the array & if the number you add 
                // exists.
                String number = txtNumber.Text.Trim();
                if (Exist(number))
                {
                    MessageBox.Show("Student already exist in list !");
                    return;
                }
                else
                {
                    Student tmp;
                    tmp.Number = number;
                    tmp.Name = txtName.Text.Trim();
                    tmp.Grade = Convert.ToSingle(txtGrade.Text);
                    //add in my array at the current position
                    listStuds[i] = tmp;
                    //clean textboxes
                    txtNumber.Text = txtName.Text = txtGrade.Text = "";
                    //move the current index for the next entity
                    i++;
                    lstNumbers.Items.Add(number);//add the number in the listbox
                }
            }
            else
            {
                MessageBox.Show("You have reach the maximum of students !");
            }
        }

        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for(int j = 0; j < i; j++)
            //{
            //    if(lstNumbers.SelectedItem != null && (lstNumbers.SelectedItem.ToString() == listStuds[j].Number))
            //    {
            //        txtInfoNB.Text = listStuds[j].Number;
            //        txtInfoName.Text = listStuds[j].Name;
            //        txtInfoGrade.Text = listStuds[j].Grade.ToString();
            //        n = j;
            //    }
            //}
           
            Int32 indx = lstNumbers.SelectedIndex;
            txtInfoNB.Text = listStuds[indx].Number;
            txtInfoName.Text = listStuds[indx].Name;
            txtInfoGrade.Text = listStuds[indx].Grade.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtInfoNB.BackColor = txtInfoName.BackColor = txtInfoGrade.BackColor = Color.Yellow;
            txtInfoNB.Focus();
          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //txtInfoNB.BackColor = txtInfoName.BackColor = txtInfoGrade.BackColor = Color.Gray;
            //listStuds[n].Number = txtInfoNB.Text;
            //listStuds[n].Name = txtInfoName.Text;
            //listStuds[n].Grade = Convert.ToSingle(txtInfoGrade.Text);
            //lstNumbers.Items[lstNumbers.SelectedIndex] = txtInfoNB.Text;

            Int32 indx = lstNumbers.SelectedIndex;
            listStuds[indx].Name = txtInfoName.Text;
            listStuds[indx].Grade = Convert.ToSingle(txtInfoGrade.Text);
            txtInfoNB.BackColor = txtInfoName.BackColor = txtInfoGrade.BackColor = Color.White;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           //if (MessageBox.Show("Are you sure to delete this student?", "Student Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
           //{
           //     txtInfoNB.Text = txtInfoName.Text = txtInfoGrade.Text = "";
           //     lstNumbers.Items.Remove(lstNumbers.SelectedItem);
           //     listStuds[n].Number = listStuds[n].Name = "";
                
           //}
            for (Int32 j = lstNumbers.SelectedIndex; j <= i; j++)
            {
                listStuds[j] = listStuds[j + 1];
            }
            i--;
            
        }
    }
}
