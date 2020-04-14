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

namespace prjWinCsClassAndCollection
{
    public partial class frmCollection : Form
    {
        public frmCollection()
        {
            InitializeComponent();
        }

        private void frmCollection_Load(object sender, EventArgs e)
        {
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
            //with typed elements
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

        }
    }
}
