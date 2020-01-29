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
                info = info + "Status :" + rdiSingle.Text + "\n";
            }else if (rdiMarried.Checked)
            {
                //info = info + "Marital Status : Married" + "\n";
                info = info + "Status : " + rdiMarried.Text + "\n";

            }else if (rdiSeparated.Checked)
            {
                //info = info + "Marital Status : Separated" + "\n";
                info = info + "Status :" + rdiSeparated.Text + "\n";

            }else if (rdiWidow.Checked)
            {
                //info = info + "Marital Status : Widow" + "\n";
                info = info + "Status :" + rdiWidow.Text + "\n";

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


        

            if (chkDelivery.Checked)
            {
                info = info + "Rented Movies :" + "\n" ;
                for (int i = 0; i < lstMovies.Items.Count; i++)
                {
                    info = info + "-" + lstMovies.Items[i].ToString() + "\n";
                }
             
            }

            info = info + "Special :" + cboSpecial.SelectedItem + "\n";
            if(cboSpecial.Text == "2 for 1")
            {
                info = info + "Price : " + (lstMovies.Items.Count + 1) / 2 * 4 +"$" + "\n";
            }
            else
            {
                info = info + "Price : " + (lstMovies.Items.Count) * 4 +"$" + "\n";
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

            cboSpecial.Items.Add("Regular");
            cboSpecial.Items.Add("Free PopCorn");
            cboSpecial.Items.Add("2 for 1");
            cboSpecial.SelectedIndex = 0;



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

       

        private void radVisa_CheckedChanged(object sender, EventArgs e)
        {
            if (radVisa.Checked)
            {
                txtCard.Focus();
            }
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
            txtTitle.Clear();
            txtTitle.Focus();
        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "")//do the validation
            { 
            lstMovies.Items.Add(txtTitle.Text);
            }
            lblTitle.Visible = txtTitle.Visible = btnAdd.Visible = false;
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lstMovies.SelectedIndex >= 0) { 
                lstMovies.Items.RemoveAt(lstMovies.SelectedIndex);
            }
        }

        private void txtCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar < '0' || e.KeyChar > '9')

            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void cboSpecial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_MouseEnter(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.Red;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = DefaultBackColor;
        }

        
    }
}
