using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class MIS_ManagerForm : Form
    {
        public MIS_ManagerForm()
        {
            InitializeComponent();
        }

        private void MIS_ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonListAllUsers_Click(object sender, EventArgs e)
        {

            User user = new User();
            List<User> listUser = new List<User>();
            listUser = user.GetUserList();
            listViewUsers.Items.Clear();
            if (listUser != null)
            {
                foreach (User userItem in listUser)
                {
                    ListViewItem item = new ListViewItem(userItem.UserId.ToString());
                    item.SubItems.Add(userItem.Password);
                    item.SubItems.Add(userItem.FirstName);
                    item.SubItems.Add(userItem.LastName);
                    item.SubItems.Add(userItem.JobTitle);
                    item.SubItems.Add(userItem.UserStatus);
                    listViewUsers.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("There is no user now!", "Confirmation");
            }

            
        }
    }
}
