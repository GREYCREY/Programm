using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        public CustomerTab()
        {
            InitializeComponent();
        }
        private static List<Customer> _customer = new List<Customer>();
        private static Customer _currentCustomer = null;
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedIndex < 0)
            {
                CustomerFullNameRichTextBox.Text = string.Empty;
                CustomerAddressRichTextBox.Text = string.Empty;
                CustomerIDTextBox.Text = string.Empty;
            }

            else
            {
                _currentCustomer = _customer[CustomerListBox.SelectedIndex];
                CustomerFullNameRichTextBox.Text = _currentCustomer.FullName.ToString();
                CustomerAddressRichTextBox.Text = _currentCustomer.Address.ToString();
                CustomerIDTextBox.Text = _currentCustomer.Id.ToString();
            }
        }
        private void CustomerFullNameRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerFullNameRichTextBox.Text)) return;
            try
            {
                CustomerFullNameRichTextBox.BackColor = Color.White;
                string customerFullName = CustomerFullNameRichTextBox.Text;
                _currentCustomer.FullName = customerFullName;
            }
            catch (Exception)
            {
                CustomerFullNameRichTextBox.BackColor = Color.LightPink;
            }
        }
        private void CustomerAddressRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerAddressRichTextBox.Text)) return;
            try
            {
                CustomerAddressRichTextBox.BackColor = Color.White;
                string customerAddress = CustomerAddressRichTextBox.Text;
                _currentCustomer.Address = customerAddress;
            }
            catch (Exception)
            {
                CustomerAddressRichTextBox.BackColor = Color.LightPink;
            }
        }
        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedIndex < 0) { return; }
            else
            {
                _customer.RemoveAt(CustomerListBox.SelectedIndex);
                CustomerListBox.Items.RemoveAt(CustomerListBox.SelectedIndex);
            }
        }
        private void AddItem_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer("Alex", "London");
            _customer.Add(newCustomer);
            CustomerListBox.Items.Add(newCustomer);
        }

        
    }
}
