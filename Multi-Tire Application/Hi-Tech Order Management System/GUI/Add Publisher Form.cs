using Hi_TechLibrary.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.Models;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class Add_Publisher_Form : Form
    {
        HiTechDBEntities dbEntities = new HiTechDBEntities();
        public Add_Publisher_Form()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string publisherId = textBoxPublisherId.Text.Trim();
            if (Validator.IsEmpty(publisherId))
            {
                MessageBox.Show("Please enter Publisher Id", "Error");
                textBoxPublisherId.Focus();
                return;
            }

            Publisher pub = new Publisher();
            pub = dbEntities.Publishers.Find(publisherId);
            if (pub != null)
            {
                MessageBox.Show("This Publisher Number already exists!", "Duplicate Publisher Number");
                textBoxPublisherId.Clear();
                textBoxPublisherId.Focus();
                return;
            }

            string name = textBoxPublisherName.Text.Trim();
            if (Validator.IsEmpty(name))
            {
                MessageBox.Show("Please enter Publisher name", "Error");
                textBoxPublisherName.Focus();
                return;
            }

            string web = textBoxWebAddress.Text.Trim();

            Publisher pub1 = new Publisher();
            pub1.PublisherId = textBoxPublisherId.Text.Trim();
            pub1.PublisherName = textBoxPublisherName.Text.Trim();
            pub1.WebAddress = textBoxWebAddress.Text.Trim();
            dbEntities.Publishers.Add(pub1);
            dbEntities.SaveChanges();
            MessageBox.Show("This publisher has been saved successfully !", "Confirmation");
            textBoxPublisherId.Clear();
            textBoxPublisherName.Clear();
            textBoxWebAddress.Clear();
        }
    }
}
