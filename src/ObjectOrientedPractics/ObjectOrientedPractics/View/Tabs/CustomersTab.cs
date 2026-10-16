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
        /// Обёртка над списком <see cref="_customers"/>, привязанная к <c>ListBox</c> через DataSource.
        /// Работает с тем же списком, поэтому добавлять и удалять покупателей нужно через неё:
        /// тогда <c>ListBox</c> узнаёт об изменениях и сам обновляется.
        /// </summary>
        private BindingList<Customer> _bindingCustomers;

        /// <summary>
        /// Возвращает и задаёт список покупателей, отображаемых на вкладке.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                _bindingCustomers = new BindingList<Customer>(_customers);
                _customersListBox.DataSource = _bindingCustomers;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            _bindingCustomers = new BindingList<Customer>(_customers);
            _customersListBox.DataSource = _bindingCustomers;
        }
        /// <summary>
        /// Обрабатывает выбранного покупателя в списке
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_customersListBox.SelectedItem is Customer selectedCustomer)
            {
                _customersIdTextBox.Text = selectedCustomer.Id.ToString();
                _customersFullNameTextBox.Text = selectedCustomer.Fullname;
                _customersAddressControl.Address = selectedCustomer.Address;
            }
            else
            {
                _customersIdTextBox.Text = string.Empty;
                _customersFullNameTextBox.Text = string.Empty;
                _customersAddressControl.Address = new Address();
            }
        }
        /// <summary>
        /// Обрабатывает нажатие кнопки добавления покупателя
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _customersAddButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer("Full Name", new Address());
            _bindingCustomers.Add(customer);
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
                _bindingCustomers.Remove(selectedCustomer);
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

                    // Сообщаем списку, что элемент изменился, чтобы он обновил отображаемое имя.
                    _bindingCustomers.ResetItem(_customersListBox.SelectedIndex);
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
            _bindingCustomers.Add(customer);
            _customersListBox.SelectedItem = customer;
        }
    }
}
