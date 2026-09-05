using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new();

        private bool _IsRefresingListBox = false;
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void _customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_IsRefresingListBox)
            {
                return;
            }
            if (_customersListBox.SelectedItem is Customer selectedCustomer)
            {
                _customersIdTextBox.Text = selectedCustomer.Id.ToString();
                _customersFullNameTextBox.Text = selectedCustomer.Fullname;
                _customersAddressTextBox.Text = selectedCustomer.Address;
            }
            else
            {
                _customersIdTextBox.Text = string.Empty;
                _customersFullNameTextBox.Text = string.Empty;
                _customersAddressTextBox.Text = string.Empty;
            }
        }

        private void _customersAddButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer("Full Name", "Address");
            _customers.Add(customer);
            _customersListBox.Items.Add(customer);
            _customersListBox.SelectedItem = customer;
        }

        private void _customersRemoveButton_Click(object sender, EventArgs e)
        {
            if (_customersListBox.SelectedItem is Customer selectedCustomer)
            {
                _customers.Remove(selectedCustomer);
                _customersListBox.Items.Remove(selectedCustomer);
            }
        }

        private void _customersAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_customersListBox.SelectedItem is Customer selectedCustomer)
            {
                try
                {
                    selectedCustomer.Address = _customersAddressTextBox.Text;
                    _customersAddressTextBox.BackColor = SystemColors.Window;
                }
                catch (ArgumentException)
                {
                    _customersAddressTextBox.BackColor = Color.Red;
                }
            }
        }

        private void _customersFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_customersListBox.SelectedItem is Customer selectedCustomer)
            {
                try
                {
                    selectedCustomer.Fullname = _customersFullNameTextBox.Text;
                    _customersFullNameTextBox.BackColor = SystemColors.Window;
                    _IsRefresingListBox = true;
                    int index = _customersListBox.SelectedIndex;
                    _customersListBox.Items.RemoveAt(index);
                    _customersListBox.Items.Insert(index, selectedCustomer);
                    _customersListBox.SelectedIndex = index;
                    _IsRefresingListBox = false;
                }
                catch (ArgumentException)
                {
                    _customersFullNameTextBox.BackColor = Color.Red;
                }
            }
        }
    }
}
