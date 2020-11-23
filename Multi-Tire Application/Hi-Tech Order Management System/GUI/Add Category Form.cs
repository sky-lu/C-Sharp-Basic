using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_TechLibrary.VALIDATION;
using Hi_Tech_Order_Management_System.Models;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class Add_Category_Form : Form
    {
        HiTechDBEntities dbEntities = new HiTechDBEntities();
        public Add_Category_Form()
        {
            InitializeComponent();
        }

        private void Add_Category_Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string categoryId = textBoxCategoryId.Text.Trim();
            if (Validator.IsEmpty(categoryId))
            {
                MessageBox.Show("Please enter Category Id", "Error");
                textBoxCategoryId.Focus();
                return;
            }

            Category cate = new Category();
            cate = dbEntities.Categories.Find(categoryId);
            if (cate != null)
            {
                MessageBox.Show("This Category Number already exists!", "Duplicate Category Number");
                textBoxCategoryId.Clear();
                textBoxCategoryId.Focus();
                return;
            }

            string name = textBoxCategoryName.Text.Trim();
            if (Validator.IsEmpty(name))
            {
                MessageBox.Show("Please enter Category name", "Error");
                textBoxCategoryName.Focus();
                return;
            }

            Category cate1 = new Category();
            cate1.CategoryId = textBoxCategoryId.Text.Trim();
            cate1.CategoryName = textBoxCategoryName.Text.Trim();
            dbEntities.Categories.Add(cate1);
            dbEntities.SaveChanges();
            MessageBox.Show("This category has been saved successfully !", "Confirmation");
            textBoxCategoryId.Clear();
            textBoxCategoryName.Clear();

        }
    }
}
