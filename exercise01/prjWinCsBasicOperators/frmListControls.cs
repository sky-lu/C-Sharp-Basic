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
    public partial class frmListControls : Form
    {
        public frmListControls()
        {
            InitializeComponent();
        }

        private void lstCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblResult.Text = lstCountries.SelectedItem.ToString();
            //lblResult.Text = lstCountries.Items[2].ToString();
            //lblResult.Text = lstCountries.SelectedIndex.ToString();
            lstCountries.Items.Clear();
           
        }

        private void frmListControls_Load(object sender, EventArgs e)
        {
            lstCountries.Items.Add("Brazil");
            lstCountries.Items.Add("Canada");
            lstCountries.Items.Add("France");
            lstCountries.Items.Add("Portugal");
            lstCountries.Items.Add("Russia");

        }
    }
}
