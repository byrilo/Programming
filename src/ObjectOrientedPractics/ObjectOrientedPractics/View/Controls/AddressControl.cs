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
