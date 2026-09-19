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
            catch (ArgumentException)
            {
                _countryTextBox.BackColor = Color.Red;
            }
        }

        private void _streetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = _streetTextBox.Text;
                _streetTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException)
            {
                _streetTextBox.BackColor = Color.Red;
            }
        }

        private void _buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = _buildingTextBox.Text;
                _buildingTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException)
            {
                _buildingTextBox.BackColor = Color.Red;
            }
        }

        private void _cityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = _cityTextBox.Text;
                _cityTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException)
            {
                _cityTextBox.BackColor = Color.Red;
            }
        }

        private void _apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = _apartmentTextBox.Text;
                _apartmentTextBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException)
            {
                _apartmentTextBox.BackColor = Color.Red;
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
                }
                catch (ArgumentOutOfRangeException)
                {
                    _postIndexTextBox.BackColor = Color.Red;
                }
            }
            else
            {
                _postIndexTextBox.BackColor = Color.Red;
            }
        }

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
