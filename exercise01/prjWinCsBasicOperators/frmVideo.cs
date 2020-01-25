using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsBasicOperators
{
    public partial class frmVideo : Form
    {
        public frmVideo()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("Thanks for using our program!","Closing Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
            //txtNumber.Text = "Test";
            String info;
            String title = "Client Information";
           
            info = "Numbers : " + txtNumber.Text + "\n";
            info = info + "Name : " + txtName.Text + "\n";
            if (chkDelivery.Checked == true){ 
                info = info + "Delivery : Yes" + "\n";
                info = info + "Address :" + txtAddress.Text + "\n";
            }
            else
            {
                info = info + "Delivery : no\n";

            }

            if (rdiSingle.Checked)
            {
                //info = info + "Marital Status : Single" + "\n";
                info = info + rdiSingle.Text + "\n";
            }else if (rdiMarried.Checked)
            {
                //info = info + "Marital Status : Married" + "\n";
                info = info + rdiMarried.Text + "\n";

            }else if (rdiSeparated.Checked)
            {
                //info = info + "Marital Status : Separated" + "\n";
                info = info + rdiSeparated.Text + "\n";

            }else if (rdiWidow.Checked)
            {
                //info = info + "Marital Status : Widow" + "\n";
                info = info + rdiWidow.Text + "\n";

            }


            if (radVisa.Checked)
            {
                info = info + "Card : " + radVisa.Text + "\n" + "N :" + txtCard.Text + "\n";
       
            }
            if (radMasterCard.Checked)
            {
                info = info + "Card : " + radMasterCard.Text + "\n" + "N :" + txtCard.Text + "\n";

            }
            if (radAMEX.Checked)
            {
                info = info + "Card : " + radAMEX.Text + "\n" + "N :" + txtCard.Text + "\n";

            }
            
            info = info + "Add all the information valid ?";


            MessageBox.Show(info, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           

        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            lblBigTitle.Text = "BLACKFLIX";
            lblBigTitle.ForeColor = Color.Navy;
            this.Text = "Video Store";
            //lblAddress.Visible = false;
            //txtAddress.Visible = false;
            lblAddress.Visible = txtAddress.Visible = false;
      
        }

        private void chkDelivery_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkDelivery.Checked == true)
            //{
            //    lblAddress.Visible = txtAddress.Visible = true;
            //}
            //else
            //{
            //    lblAddress.Visible = txtAddress.Visible = false;

            //}
            lblAddress.Visible = txtAddress.Visible = btnRent.Visible = chkDelivery.Checked;
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radVisa_CheckedChanged(object sender, EventArgs e)
        {
            if (radVisa.Checked)
            {
                txtCard.Focus();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radMasterCard_CheckedChanged(object sender, EventArgs e)
        {
            txtCard.Focus();

        }

        private void radAMEX_CheckedChanged(object sender, EventArgs e)
        {
            txtCard.Focus();

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            lblTitle.Visible = txtTitle.Visible = btnAdd.Visible = true;
        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
