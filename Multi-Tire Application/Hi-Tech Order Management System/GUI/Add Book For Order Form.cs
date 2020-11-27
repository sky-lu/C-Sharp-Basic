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
    public partial class Add_Book_For_Order_Form : Form
    {
        HiTechDBEntities dbEntities = new HiTechDBEntities();
        public Add_Book_For_Order_Form()
        {
            InitializeComponent();
        }

        private void Add_Book_For_Order_Form_Load(object sender, EventArgs e)
        {
            textBoxOrderId.Text = Order_Management_Form.SetValueForOrderId;
            textBoxOrderId.Enabled = false;

            var listBook = from book in dbEntities.Books
                           select book;
            foreach (Book book in listBook)
            {
                comboBoxBookId.Items.Add(book.ISBN);
            }
        }

        private void comboBoxBookId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxBookId.SelectedIndex;
            if (selectedIndex != -1) { 
                string isbn = comboBoxBookId.SelectedItem.ToString();
                Book book = new Book();
                book = dbEntities.Books.Find(isbn);
                labelBookInfo.Text = "Book Title : " + book.BookTitle + "\n" + "QOH :" + book.QOH.ToString()
                                    + "\n" + "Unit Price : " + book.UnitPrice.ToString();
            }
            else
            {
                labelBookInfo.Text = "";
            }
        }

        private void buttonAddTOOrder_Click(object sender, EventArgs e)
        {
            string orderId = textBoxOrderId.Text.Trim();
            int selectedIndex = comboBoxBookId.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select Book Id first!", "Confirmation");
                return;
            }

            string isbn = comboBoxBookId.SelectedItem.ToString();

            OrderLine orderline = new OrderLine();
            orderline = dbEntities.OrderLines.Find(orderId, isbn);
            if (orderline != null)
            {
                MessageBox.Show("This book was added to this order before!", "Duplicate addition");
                comboBoxBookId.SelectedIndex = -1;
                return;
            }
            else 
            {
                OrderLine orderline1 = new OrderLine();
                orderline1.OrderId = textBoxOrderId.Text.Trim();
                orderline1.ISBN = comboBoxBookId.Text.Trim();
                dbEntities.OrderLines.Add(orderline1);
                dbEntities.SaveChanges();
                MessageBox.Show("This book has been added to this order successfully !", "Confirmation");
                labelBookInfo.Text = "";
                comboBoxBookId.SelectedIndex = -1;
            }
        }

        private void buttonAddNewBook_Click(object sender, EventArgs e)
        {
            Book_Management_Form form_book = new Book_Management_Form();
            form_book.ShowDialog();
            
            var listBook = from book in dbEntities.Books
                           select book;
            foreach (Book book in listBook)
            {
                comboBoxBookId.Items.Add(book.ISBN);
            }
        }
    }
}
