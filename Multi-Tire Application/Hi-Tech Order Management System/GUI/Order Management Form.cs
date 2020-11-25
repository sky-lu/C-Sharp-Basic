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
        public Order_Management_Form()
        {
            InitializeComponent();
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
    }
}
