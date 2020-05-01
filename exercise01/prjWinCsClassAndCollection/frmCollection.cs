using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace prjWinCsClassAndCollection
{
    public partial class frmCollection : Form
    {

        public frmCollection()
        {
            InitializeComponent();
        }

        Dictionary<String, clsStudent> listStuds;
        private void frmCollection_Load(object sender, EventArgs e)
        {
            listStuds = new Dictionary<string, clsStudent>();
            readFile2Collection();
           //Collection with index
            //-- With untyped elements --
            //ArrayList myList = new ArrayList();
            //myList.Add("cat");
            //Int16 Age = 25;
            //myList.Add(Age);
            //myList.Add(DateTime.Today);
            //MessageBox.Show(myList.Count.ToString());
            ////for (Int16 i = 0; i < myList.Count; i++)
            ////{
            ////    MessageBox.Show(myList[i].ToString());
            ////}
            //foreach(object element in myList)
            //{
            //    MessageBox.Show(element.ToString());
            //}
            //-----------------------------------------------------------------------
            //collection with Index
            //with typed elements (generic collection)
            //List<String> myLadies = new List<string>();
            //myLadies.Add("Helen");
            //myLadies.Add("Rose");
            //myLadies.Add("Jas");
            //foreach (String item in myLadies)
            //{
            //    MessageBox.Show(item);
            //}

            //List<clsStudent> colStuds = new List<clsStudent>();
            //clsStudent st1 = new clsStudent("Carla", "123456789", 95);
            //colStuds.Add(st1);

            //clsStudent st2 = new clsStudent("Jack", "123456789", 93);
            //colStuds.Add(st2);

            //colStuds.Add(new clsStudent("Tom", "123456789", 90));

            //foreach (clsStudent item in colStuds)
            //{
            //    MessageBox.Show(item.Display());
            //}

            //------------------------------------------------------------------------------------------
            //collection with keys (untyped)
            //Hashtable myCol = new Hashtable(); 
            //clsStudent st1 = new clsStudent("Carla", "123456789", 95);
            //myCol.Add(1, st1);
            //myCol.Add("Two", "Marco Polo");
            //myCol.Add('d', DateTime.Today);
            //MessageBox.Show(((clsStudent)myCol[1]).Display());
            //------------------------------------------------------------------------------------------
            //Dictionary<String, clsStudent> colStuds = new Dictionary<string, clsStudent>();
            //clsStudent st1 = new clsStudent("Carla", "5141", 95);
            //colStuds.Add(st1.Telephone, st1);

            //clsStudent st2 = new clsStudent("Jack", "911", 93);
            //colStuds.Add(st2.Telephone, st2);

            //colStuds.Add("5412", new clsStudent("Tom", "5412", 90));
            ////foreach (clsStudent item in colStuds.Values)//**(String item in colStuds.Keys)
            ////{
            ////    MessageBox.Show(item.Display());
            ////}

            //MessageBox.Show(colStuds["911"].Display());
            //----------------------------------------------------------------------------------------------
        }

        private void readFile2Collection()
        {
            StreamReader myFile = new StreamReader("College.txt");
            while (!myFile.EndOfStream)
            {
                String num = myFile.ReadLine();
                String name = myFile.ReadLine();
                Single grade = Convert.ToSingle(myFile.ReadLine());
                clsStudent st = new clsStudent(num, name, grade);
                listStuds.Add(st.Number, st);//Add the current student in the collection
                //Add the number in the listbox
                lstNumbers.Items.Add(st.Number);
                st = null;
            }

            myFile.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstNumbers.SelectedIndex != -1) { 
                String numberSearch = lstNumbers.SelectedItem.ToString();
                clsStudent found = listStuds[numberSearch];//the collection will return the clsStudent  within the key numberSearch
                lblNumber.Text = found.Number;
                txtName.Text = found.Name;
                txtGrade.Text = found.Grade.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            listStuds[lblNumber.Text].Name = txtName.Text;
            listStuds[lblNumber.Text].Grade = Convert.ToSingle(txtGrade.Text);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listStuds.Remove(lblNumber.Text);
            lstNumbers.Items.Remove(lblNumber.Text);
            lstNumbers.SelectedIndex = -1;
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
