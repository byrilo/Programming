using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        public AddressControl()
        {
            InitializeComponent();
        }
        private void ShowAddress()
        {
            _postIndexTextBox.Text = _address.Index.ToString();
            _countryTextBox.Text = _address.Country;
            _cityTextBox.Text = _address.City;
            _streetTextBox.Text = _address.Street;
            _buildingTextBox.Text = _address.Building;
            _apartmentTextBox.Text = _address.Apartment;
        }

        private void _countryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = _countryTextBox.Text;
                _countryTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException ex)
            {
                _countryTextBox.BackColor = Color.Red;
                _addressErrorProvider.SetError(_countryTextBox, ex.Message);
            }
        }

        private void _streetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = _streetTextBox.Text;
                _streetTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException ex)
            {
                _streetTextBox.BackColor = Color.Red;
                _addressErrorProvider.SetError(_streetTextBox, ex.Message);
            }
        }

        private void _buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = _buildingTextBox.Text;
                _buildingTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException ex)
            {
                _buildingTextBox.BackColor = Color.Red;
                _addressErrorProvider.SetError(_buildingTextBox, ex.Message);
            }
        }

        private void _cityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = _cityTextBox.Text;
                _cityTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException ex)
            {
                _cityTextBox.BackColor = Color.Red;
                _addressErrorProvider.SetError(_cityTextBox, ex.Message);
            }
        }

        private void _apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = _apartmentTextBox.Text;
                _apartmentTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException ex)
            {
                _apartmentTextBox.BackColor = Color.Red;
                _addressErrorProvider.SetError(_apartmentTextBox, ex.Message);
            }
        }

        private void _postIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(_postIndexTextBox.Text, out int index))
            {
                try
                {
                    _address.Index = index;
                    _postIndexTextBox.BackColor = SystemColors.Window;
                    _addressErrorProvider.SetError(_postIndexTextBox, string.Empty);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    _postIndexTextBox.BackColor = Color.Red;
                    _addressErrorProvider.SetError(_postIndexTextBox, "Индекс должен быть шестизначным числом.");
                }
            }
            else
            {
                _postIndexTextBox.BackColor = Color.Red;
                _addressErrorProvider.SetError(_postIndexTextBox, "Индекс должен быть числом.");
            }
        }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                ShowAddress();
            }
        }

    }
}
