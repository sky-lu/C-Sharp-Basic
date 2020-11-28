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
    public partial class Order_Management_Form : Form
    {
        HiTechDBEntities dbEntities = new HiTechDBEntities();
        public static string SetValueForOrderId = "";
        public Order_Management_Form()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                this.Hide();
                Login_Form form_login = new Login_Form();
                form_login.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void buttonListOrder_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            var listOrder = from order in dbEntities.Orders
                           select order;
            if (listOrder.Count() != 0)
            {
                foreach (var order in listOrder)
                {
                    ListViewItem item = new ListViewItem(order.OrderId);
                    item.SubItems.Add(order.OrderDate.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(order.RequiredDate.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(order.ShippingDate.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(order.OrderType);
                    item.SubItems.Add(order.OrderStatus);
                    item.SubItems.Add(order.CustomerId.ToString());
                    item.SubItems.Add(order.EmployeeId.ToString());
                    listViewOrder.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("There is no order now!", "Confirmation");
            }
        }

        private void Order_Management_Form_Load(object sender, EventArgs e)
        {
            var listCustomer = from customer in dbEntities.Customers
                               select customer;
            comboBoxCustomerName.DataSource = listCustomer.ToList();
            comboBoxCustomerName.DisplayMember = "CustomerName";
            comboBoxCustomerName.ValueMember = "CustomerId";
            comboBoxCustomerName.SelectedIndex = -1;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string orderId = textBoxOrderId.Text.Trim();
            if (Validator.IsEmpty(orderId))
            {
                MessageBox.Show("Please enter Order Id", "Empty Error");
                textBoxOrderId.Focus();
                return;
            }
            Order order = new Order();
            order = dbEntities.Orders.Find(orderId);
            if (order != null)
            {
                MessageBox.Show("This Order Number already exists!", "Duplicate Order Number");
                textBoxOrderId.Clear();
                textBoxOrderId.Focus();
                return;
            }

            DateTime orderDate = Convert.ToDateTime(maskedTextBoxOrderDate.Text.Trim());
            

            DateTime requiredDate = Convert.ToDateTime(maskedTextBoxRequiredDate.Text.Trim());
            
            DateTime shipDate = Convert.ToDateTime(maskedTextBoxShipDate.Text.Trim());
            

            int result1 = DateTime.Compare(orderDate, requiredDate);
            int result2 = DateTime.Compare(shipDate, requiredDate);
            int result3 = DateTime.Compare(orderDate, shipDate);
            if (result1 >= 0 || result2 >= 0 || result3 >= 0)
            {
                MessageBox.Show("Please change the Date, some dates are nort reasonable!", "Error");
                return;
            }


            int selectedIndex_type = comboBoxOrderType.SelectedIndex;
            if (selectedIndex_type == -1)
            {
                MessageBox.Show("Please select Order Type for this order !", "Select Requirement");
                return;
            }

            int selectedIndex_status = comboBoxOrderStatus.SelectedIndex;
            if (selectedIndex_status == -1)
            {
                MessageBox.Show("Please select Order Status for this order !", "Select Requirement");
                return;
            }

            int selectedIndex_name = comboBoxCustomerName.SelectedIndex;
            if (selectedIndex_name == -1)
            {
                MessageBox.Show("Please select Customer Name for this order !", "Select Requirement");
                return;
            }
            int selectedIndex_employeeId = comboBoxEmployeeId.SelectedIndex;
            if (selectedIndex_employeeId == -1)
            {
                MessageBox.Show("Please select Employee Id for this order !", "Select Requirement");
                return;
            }


            Order order1 = new Order();
            order1.OrderId = textBoxOrderId.Text.Trim();
            order1.OrderDate = Convert.ToDateTime(maskedTextBoxOrderDate.Text.Trim());
            order1.RequiredDate = Convert.ToDateTime(maskedTextBoxRequiredDate.Text.Trim());
            order1.ShippingDate = Convert.ToDateTime(maskedTextBoxShipDate.Text.Trim());
            order1.OrderType = comboBoxOrderType.SelectedItem.ToString();
            order1.OrderStatus = comboBoxOrderStatus.SelectedItem.ToString();
            order1.CustomerId = Convert.ToInt32(comboBoxCustomerName.SelectedValue);
            order1.EmployeeId = Convert.ToInt32(comboBoxEmployeeId.SelectedItem);

            dbEntities.Orders.Add(order1);
            dbEntities.SaveChanges();
            textBoxOrderId.Clear();
            maskedTextBoxOrderDate.Clear();
            maskedTextBoxRequiredDate.Clear();
            maskedTextBoxShipDate.Clear();
            comboBoxOrderType.SelectedIndex = -1;
            comboBoxOrderStatus.SelectedIndex = -1;
            comboBoxCustomerName.SelectedIndex = -1;
            comboBoxEmployeeId.SelectedIndex = -1;
            labelBookInfo.Text = "";
            
            MessageBox.Show("Order has been saved successfully!", "Confirmation");
        }

        private void buttonSearchOrder_Click(object sender, EventArgs e)
        {
            textBoxOrderId.Clear();
            maskedTextBoxOrderDate.Clear();
            maskedTextBoxRequiredDate.Clear();
            maskedTextBoxShipDate.Clear();
            comboBoxOrderType.SelectedIndex = -1;
            comboBoxOrderStatus.SelectedIndex = -1;
            comboBoxCustomerName.SelectedIndex = -1;
            comboBoxEmployeeId.SelectedIndex = -1;
            listViewOrder.Items.Clear();
            labelBookInfo.Text = "";
            int selectedIndex = comboBoxSearchOrder.SelectedIndex;
            if (selectedIndex == 0)
            {
                string orderId = textBoxSearch.Text.Trim();
                if (Validator.IsEmpty(orderId))
                {
                    MessageBox.Show("Please enter search information", "Error");
                    textBoxSearch.Focus();
                    return;
                }
                Order order = new Order();
                order = dbEntities.Orders.Find(orderId);
                if (order != null)
                {
                    textBoxOrderId.Text = order.OrderId;
                    maskedTextBoxOrderDate.Text = order.OrderDate.ToString("MM-dd-yyyy");
                    maskedTextBoxRequiredDate.Text = order.RequiredDate.ToString("MM-dd-yyyy");
                    maskedTextBoxShipDate.Text = order.ShippingDate.ToString("MM-dd-yyyy");
                    comboBoxOrderType.SelectedItem = order.OrderType;
                    comboBoxOrderStatus.SelectedItem = order.OrderStatus;
                    comboBoxCustomerName.SelectedValue = order.CustomerId;
                    comboBoxEmployeeId.SelectedItem = order.EmployeeId.ToString();
                    

                    var listBookId = from orderLine in dbEntities.OrderLines.Where(x => x.OrderId == order.OrderId)
                                       select orderLine.ISBN;
                    if (listBookId.Count() == 0)
                    {
                        labelBookInfo.Text = "No book was added to this order for now !";
                    }
                    else
                    {
                        foreach (string isbn in listBookId)
                        {
                            Book book = dbEntities.Books.Find(isbn);
                            string display;
                            display = "Book Title : " + book.BookTitle + "\n" + "QOH :" + book.QOH.ToString()
                                    + "\n" + "Unit Price : " + book.UnitPrice.ToString();
                            labelBookInfo.Text = labelBookInfo.Text + display;
                        }
                    }

                    return;
                }
                else
                {
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    MessageBox.Show("This Order Number doesn't exit!", "Confirmation");
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string orderId = textBoxOrderId.Text.Trim();
            Order order = new Order();
            order = dbEntities.Orders.Find(orderId);
            if (order != null)
            {
                order.OrderId = textBoxOrderId.Text.Trim();
                order.OrderDate = Convert.ToDateTime(maskedTextBoxOrderDate.Text.Trim());
                order.RequiredDate = Convert.ToDateTime(maskedTextBoxRequiredDate.Text.Trim());
                order.ShippingDate = Convert.ToDateTime(maskedTextBoxShipDate.Text.Trim());
                order.OrderType = comboBoxOrderType.SelectedItem.ToString();
                order.OrderStatus = comboBoxOrderStatus.SelectedItem.ToString();
                order.CustomerId = Convert.ToInt32(comboBoxCustomerName.SelectedValue);
                order.EmployeeId = Convert.ToInt32(comboBoxEmployeeId.SelectedItem);

                dbEntities.SaveChanges();
                MessageBox.Show("Order has been updated successfully", "Confirmation");
            }
            else
            {
                MessageBox.Show("Order not found", "error");
                return;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string orderId = textBoxOrderId.Text.Trim();
            Order order = new Order();
            order = dbEntities.Orders.Find(orderId);

            if (order != null)
            {
                var result = MessageBox.Show("Are you sure to delete this order?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    var listOrderline = from orderline in dbEntities.OrderLines.Where(x => x.OrderId == orderId)
                                        select orderline;
                    if (listOrderline.Count() == 0)
                    {
                        dbEntities.Orders.Remove(order);
                        dbEntities.SaveChanges();
                        textBoxOrderId.Clear();
                        maskedTextBoxOrderDate.Clear();
                        maskedTextBoxRequiredDate.Clear();
                        maskedTextBoxShipDate.Clear();
                        comboBoxOrderType.SelectedIndex = -1;
                        comboBoxOrderStatus.SelectedIndex = -1;
                        comboBoxCustomerName.SelectedIndex = -1;
                        comboBoxEmployeeId.SelectedIndex = -1;
                        labelBookInfo.Text = "";
                        comboBoxSearchOrder.SelectedIndex = -1;
                        textBoxSearch.Clear();
                        listViewOrder.Items.Clear();

                        MessageBox.Show("Order deleted successfully!", "Confirmation");
                    }
                    else
                    {
                        MessageBox.Show("This order has related order line, please delete them first ", "Confirmation");
                    }

                }

            }
            else
            {
                MessageBox.Show("Order not found", "Error");
                return;
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            SetValueForOrderId = textBoxOrderId.Text.Trim();
            Add_Book_For_Order_Form form_add_book = new Add_Book_For_Order_Form();
            form_add_book.ShowDialog();
            var listISBN = from orderline in dbEntities.OrderLines.Where(x => x.OrderId == SetValueForOrderId)
                               select orderline.ISBN;
            labelBookInfo.Text = "";
            foreach (string isbn in listISBN)
            {
                Book book = dbEntities.Books.Find(isbn);
                string display = "Book Title : " + book.BookTitle + "\n" + "QOH :" + book.QOH.ToString()
                                    + "\n" + "Unit Price : " + book.UnitPrice.ToString();
                labelBookInfo.Text = labelBookInfo.Text + display;
            }
        }
    }
}
