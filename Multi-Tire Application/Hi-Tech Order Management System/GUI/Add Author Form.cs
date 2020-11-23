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
    public partial class Add_Author_Form : Form
    {
        HiTechDBEntities dbEntities = new HiTechDBEntities();
        public Add_Author_Form()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string authorId = textBoxAuthorId.Text.Trim();
            if (!Validator.IsValidId(authorId, 4))
            {
                MessageBox.Show("Invalid author Id !", "Confirmation");
                textBoxAuthorId.Clear();
                textBoxAuthorId.Focus();
                return;
            }

            Author author = new Author();
            AuthorsBook authorBook = new AuthorsBook();
            author = dbEntities.Authors.Find(Convert.ToInt32(authorId));
            if (author != null)
            {
                authorBook.AuthorId = Convert.ToInt32(textBoxAuthorId.Text.Trim());
                authorBook.ISBN = textBoxBookISBN.Text.Trim();
                dbEntities.AuthorsBooks.Add(authorBook);
                dbEntities.SaveChanges();
                MessageBox.Show("This author already exists and has been added to this book!", "Confirmation");
                textBoxAuthorId.Clear();
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxEmail.Clear();
                return;
            }

            string Fname = textBoxFirstName.Text.Trim();
            if ( !Validator.IsValidName(Fname))
            {
                MessageBox.Show("Invalid first name !", "Error");
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return;
            }

            string Lname = textBoxLastName.Text.Trim();
            if (!Validator.IsValidName(Lname))
            {
                MessageBox.Show("Invalid last name !", "Error");
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return;
            }

            string email = textBoxEmail.Text.Trim();
            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email !", "Error");
                textBoxEmail.Clear();
                textBoxEmail.Focus();
                return;
            }


            Author author1 = new Author();
            author1.AuthorId = Convert.ToInt32(textBoxAuthorId.Text.Trim());
            author1.FirstName = textBoxFirstName.Text.Trim();
            author1.LastName = textBoxLastName.Text.Trim();
            author1.Email = textBoxEmail.Text.Trim();
            dbEntities.Authors.Add(author1);
            MessageBox.Show("This author has been saved and added to this book successfully !", "Confirmation");
            textBoxAuthorId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();

            authorBook.AuthorId = Convert.ToInt32(textBoxAuthorId.Text.Trim());
            authorBook.ISBN = textBoxBookISBN.Text.Trim();
            dbEntities.AuthorsBooks.Add(authorBook);
            
            dbEntities.SaveChanges();


            
        }

        private void Add_Author_Form_Load(object sender, EventArgs e)
        {
            textBoxBookISBN.Text = Book_Management_Form.SetValueForISBN;
            textBoxBookISBN.Enabled = false;
        }
    }
}
