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
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Признак того, что список элементов обновляется программно
        /// (используется, чтобы избежать зацикливания событий).
        /// </summary>
        private bool _IsRefreshingListBox = false;
        public CustomersTab()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обрабатывает выбранного покупателя в списке
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_IsRefreshingListBox)
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
        /// <summary>
        /// Обрабатывает нажатие кнопки добавления покупателя
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _customersAddButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer("Full Name", "Address");
            _customers.Add(customer);
            _customersListBox.Items.Add(customer);
            _customersListBox.SelectedItem = customer;
        }
        /// <summary>
        /// Обрабатывает нажатие кнопки удаления покупателя
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _customersRemoveButton_Click(object sender, EventArgs e)
        {
            if (_customersListBox.SelectedItem is Customer selectedCustomer)
            {
                _customers.Remove(selectedCustomer);
                _customersListBox.Items.Remove(selectedCustomer);
            }
        }
        /// <summary>
        /// Обрабатывает измененеие адресса покупателя
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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
        /// <summary>
        /// Обрабатывает изменение полного имени покупателя
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _customersFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_customersListBox.SelectedItem is Customer selectedCustomer)
            {
                try
                {
                    selectedCustomer.Fullname = _customersFullNameTextBox.Text;
                    _customersFullNameTextBox.BackColor = SystemColors.Window;
                    _IsRefreshingListBox = true;
                    int index = _customersListBox.SelectedIndex;
                    _customersListBox.Items.RemoveAt(index);
                    _customersListBox.Items.Insert(index, selectedCustomer);
                    _customersListBox.SelectedIndex = index;
                    _IsRefreshingListBox = false;
                }
                catch (ArgumentException)
                {
                    _customersFullNameTextBox.BackColor = Color.Red;
                }
            }
        }
        /// <summary>
        /// Обрабатывает нажатие кнопки генерации случайных покупателей
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _customersRandomButton_Click(object sender, EventArgs e)
        {
            var customer = CustomerFactory.GetRandomCustomer();
            _customers.Add(customer);
            _customersListBox.Items.Add(customer);
            _customersListBox.SelectedItem = customer;
        }
    }
}
