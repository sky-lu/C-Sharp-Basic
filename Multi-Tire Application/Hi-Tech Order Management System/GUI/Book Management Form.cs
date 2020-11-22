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
using Hi_TechLibrary.VALIDATION;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class Book_Management_Form : Form
    {
        HiTechDBEntities dbEntities = new HiTechDBEntities();
        public Book_Management_Form()
        {
            InitializeComponent();
        }

        private void Book_Management_Form_Load(object sender, EventArgs e)
        {
            var listCategory = from cate in dbEntities.Categories
                               select cate;
            comboBoxCategoryName.DataSource = listCategory.ToList();
            comboBoxCategoryName.DisplayMember = "CategoryName";
            comboBoxCategoryName.ValueMember = "CategoryId";
            comboBoxCategoryName.SelectedIndex = -1;

            //foreach (Category cate in listCategory)
            //{
            //    comboBoxCategoryName.Items.Add(cate.CategoryName);
            //}

            var listPublisher = from publisher in dbEntities.Publishers
                                select publisher;
            comboBoxPublisherName.DataSource = listPublisher.ToList();
            comboBoxPublisherName.DisplayMember = "PublisherName";
            comboBoxPublisherName.ValueMember = "PublisherId";
            comboBoxPublisherName.SelectedIndex = -1;
            //foreach (Publisher publisher in listPublisher)
            //{
            //    comboBoxPublisherName.Items.Add(publisher.PublisherName);
            //}
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void buttonListBook_Click(object sender, EventArgs e)
        {
            listViewBook.Items.Clear();
            var listBook = from book in dbEntities.Books
                          select book;
            if (listBook.Count() != 0)
            {
                foreach (var book in listBook)
                {
                    ListViewItem item = new ListViewItem(book.ISBN.ToString());
                    item.SubItems.Add(book.BookTitle);
                    item.SubItems.Add(book.QOH.ToString());
                    item.SubItems.Add(book.UnitPrice.ToString());
                    item.SubItems.Add(book.CategoryId);
                    item.SubItems.Add(book.PublisherId);
                    listViewBook.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("There is no book now!", "Confirmation");
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            string isbn = textBoxISBN.Text.Trim();
            if (!Validator.IsValidId(isbn, 13))
            {
                MessageBox.Show("Invalid ISBN", "Error");
                textBoxISBN.Clear();
                textBoxISBN.Focus();
                return;
            }
            Book book = new Book();
            book = dbEntities.Books.Find(isbn);
            if (book != null)
            {
                MessageBox.Show("This Book Number already exists!", "Duplicate Book Number");
                textBoxISBN.Clear();
                textBoxISBN.Focus();
                return;
            }

            string title = textBoxBookTitle.Text.Trim();
            if (Validator.IsEmpty(title))
            {
                MessageBox.Show("Please enter book title !", "Empty error");
                textBoxBookTitle.Focus();
                return;
            }

            string quantity = textBoxQOH.Text.Trim();
            if(!Validator.IsNumber(quantity))
            {
                MessageBox.Show("Invalid quantity number !", "Error");
                textBoxQOH.Clear();
                textBoxQOH.Focus();
                return;
            }

            string price = textBoxUnitPrice.Text.Trim();
            Double number;
            if ( ! Double.TryParse(price, out number))
            {
                MessageBox.Show("Invalid Price", "Error");
                textBoxUnitPrice.Clear();
                textBoxUnitPrice.Focus();
                return;
            }

            int selectedIndex_C = comboBoxCategoryName.SelectedIndex;
            if (selectedIndex_C == -1)
            {
                MessageBox.Show("Please select Category for this book !", "Select Requirement");
                return;
            }

            int selectedIndex_P = comboBoxPublisherName.SelectedIndex;
            if (selectedIndex_P == -1)
            {
                MessageBox.Show("Please select publisher for this book !", "Select Requirement");
                return;
            }
            
            
            
            Book book1 = new Book();
            book1.ISBN = textBoxISBN.Text.Trim();
            book1.BookTitle = textBoxBookTitle.Text.Trim();
            book1.QOH = Convert.ToInt32(textBoxQOH.Text.Trim());
            book1.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text.Trim());
            book1.CategoryId = comboBoxCategoryName.SelectedValue.ToString();
            book1.PublisherId = comboBoxPublisherName.SelectedValue.ToString();

            dbEntities.Books.Add(book1);
            dbEntities.SaveChanges();
            textBoxISBN.Clear();
            textBoxBookTitle.Clear();
            textBoxQOH.Clear();
            textBoxUnitPrice.Clear();
            comboBoxCategoryName.SelectedIndex = -1;
            comboBoxPublisherName.SelectedIndex = -1;
            MessageBox.Show("Book has been saved successfully!", "Confirmation");

        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            textBoxISBN.Clear();
            textBoxBookTitle.Clear();
            textBoxQOH.Clear();
            textBoxUnitPrice.Clear();
            comboBoxCategoryName.SelectedIndex = -1;
            comboBoxPublisherName.SelectedIndex = -1;

            int selectedIndex = comboBoxSearchBook.SelectedIndex;
            if (selectedIndex == 0)
            {
                string isbn = textBoxSearch.Text.Trim();
                if (!Validator.IsValidId(isbn, 13))
                {
                    MessageBox.Show("Invalid Book Number", "Error");
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    return;
                }
                Book book = new Book();
                book = dbEntities.Books.Find(isbn);
                if (book != null)
                {
                    textBoxISBN.Text = book.ISBN;
                    textBoxBookTitle.Text = book.BookTitle;
                    textBoxQOH.Text = book.QOH.ToString();
                    textBoxUnitPrice.Text = book.UnitPrice.ToString();
                    comboBoxCategoryName.SelectedValue = book.CategoryId;
                    comboBoxPublisherName.SelectedValue = book.PublisherId;

                    var listAuthorId = from bookAuthor in dbEntities.AuthorsBooks.Where(x => x.ISBN == book.ISBN)
                                          select bookAuthor.AuthorId;
                    if (listAuthorId.Count() == 0)
                    {
                        labelAuthorInfo.Text = "No author was added to this book !";
                    }
                    else
                    {
                        foreach (Int32 authorId in listAuthorId)
                        {
                            Author author = dbEntities.Authors.Find(authorId);
                            string display;
                            display = author.AuthorId.ToString() + "\n" + author.FirstName
                                + "\n" + author.LastName + "\n" + author.Email;
                            labelAuthorInfo.Text = labelAuthorInfo.Text + display;
                        }
                    }
                    
                    return;
                }
                else
                {
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    MessageBox.Show("This Book Number doesn't exit!", "Confirmation");
                }
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string isbn = textBoxISBN.Text.Trim();
            Book book = new Book();
            book = dbEntities.Books.Find(isbn);
            if (book != null)
            {
                book.ISBN = textBoxISBN.Text.Trim();
                book.BookTitle = textBoxBookTitle.Text.Trim();
                book.QOH = Convert.ToInt32(textBoxQOH.Text.Trim());
                book.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text.Trim());
                book.CategoryId = comboBoxCategoryName.SelectedValue.ToString();
                book.PublisherId = comboBoxPublisherName.SelectedValue.ToString();
                dbEntities.SaveChanges();
                MessageBox.Show("Book has been updated successfully", "Confirmation");
            }
            else
            {
                MessageBox.Show("Book not found", "error");
                return;
            }
        }
    }
    
}
