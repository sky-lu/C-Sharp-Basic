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
    public partial class frmBookString : Form
    {
        public frmBookString()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Name validation
            string fullname,firstname,lastname;
            fullname = txtFullname.Text.Trim();
            if(fullname.Length == 0)
            {
                MessageBox.Show("Please enter lastname,firstname");
                txtFullname.Focus();
                return;
            }else if(fullname.IndexOf(',') == -1)
            {
                MessageBox.Show("Please enter a comma between lastname and firstname");
                txtFullname.Focus();
                return;
            }else if (fullname.IndexOf(',') == 0 )
            {
                MessageBox.Show("Please enter lastname");
                txtFullname.Focus();
            }else if (fullname.IndexOf(',') == fullname.Length - 1)
            {
                MessageBox.Show("Please enter firstname");
                txtFullname.Focus();
            }else 
            {
                firstname = fullname.Substring(fullname.IndexOf(',') + 1);
                firstname = firstname.Trim();
                lastname = fullname.Substring(0, fullname.IndexOf(','));
                lastname = lastname.Trim();

                //Show the name in the lable ,first letter capital,the other letters lower case.
                lblFirstname.Text = firstname.Substring(0,1).ToUpper() + firstname.Substring(1).ToLower();
                lblLastname.Text = lastname.Substring(0,1).ToUpper() + lastname.Substring(1).ToLower();
            }



            // Address Validation
            string address;
            address = txtAddress.Text.Trim();
            if (address.Length == 0)
            {
                MessageBox.Show("Please enter address");
                txtAddress.Focus();
                return;
            }
            else
            {
                lblAddress.Text = address.Trim();
            }



            // City, Province, Postal validation(check one by one, for example,if (city.length == 0))
            //order: info.length , first comma(poc1 == -1) , city, second comma, province, postal code
            string city, province, postal, info;
            info = txtCPPC.Text.Trim();
            if (info.Length == 0)
            {
                MessageBox.Show("please enter city, province, postal code");
                txtCPPC.Focus();
                return;
            }
            else if (info.IndexOf(',') == -1)
            {
                MessageBox.Show("Please enter ','");
                txtCPPC.Focus();
                return;
            }
            else if (info.IndexOf(',') == 0)
            {
                MessageBox.Show("Please enter city");
                txtCPPC.Focus();
            }
            else if (info.IndexOf(',') == info.Length - 1)
            {
                MessageBox.Show("Please enter postal code");
                txtCPPC.Focus();

            }
            else
            {
                city = info.Substring(0, info.IndexOf(','));
                city = city.Trim();
                lblCity.Text = city.Substring(0, 1).ToUpper() + city.Substring(1).ToLower();
                province = info.Substring(info.IndexOf(',') + 1, info.IndexOf(',', info.IndexOf(',') + 1) - info.IndexOf(',') - 1);
                province = province.Trim();
                lblProvince.Text = province.Substring(0, 1).ToUpper() + province.Substring(1).ToLower();
                postal = info.Substring(info.IndexOf(',', info.IndexOf(',') + 1) + 1);
                postal = postal.Trim();
                lblPostal.Text = postal.ToUpper();
            }

        }

        private void txtFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}
