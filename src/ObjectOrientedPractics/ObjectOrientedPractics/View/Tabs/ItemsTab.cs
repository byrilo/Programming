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

    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Признак того, что список элементов обновляется программно
        /// (используется, чтобы избежать зацикливания событий).
        /// </summary>
        private bool _isRefreshingListBox = false;

        public ItemsTab()
        {
            InitializeComponent();

        }
        private void _addButton_Click(object sender, EventArgs e)
        {
            var item = new Item("Item", "", 0);
            _items.Add(item);
            _itemsListBox.Items.Add(item);
            _itemsListBox.SelectedItem = item;
        }
        private void _removeButton_Click(object sender, EventArgs e)
        {
            if (_itemsListBox.SelectedItem is Item selectedItem)
            {
                _items.Remove(selectedItem);
                _itemsListBox.Items.Remove(selectedItem);
            }
        }
        private void _itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRefreshingListBox)
            {
                return;
            }

            if (_itemsListBox.SelectedItem is Item selectedItem)
            {
                _idTextBox.Text = selectedItem.Id.ToString();
                _nameTextBox.Text = selectedItem.Name;
                _descriptionTextBox.Text = selectedItem.Info;
                _costTextBox.Text = selectedItem.Cost.ToString();
            }
            else
            {
                _idTextBox.Clear();
                _nameTextBox.Clear();
                _descriptionTextBox.Clear();
                _costTextBox.Clear();
            }
        }
        private void _nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_itemsListBox.SelectedItem is Item selectedItem)
            {
                try
                {
                    selectedItem.Name = _nameTextBox.Text;
                    _nameTextBox.BackColor = SystemColors.Window;

                    _isRefreshingListBox = true;
                    int index = _itemsListBox.SelectedIndex;
                    _itemsListBox.Items.RemoveAt(index);
                    _itemsListBox.Items.Insert(index, selectedItem);
                    _itemsListBox.SelectedIndex = index;
                    _isRefreshingListBox = false;
                }
                catch (ArgumentException)
                {
                    _nameTextBox.BackColor = Color.Red;
                }
            }
        }
        private void _descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_itemsListBox.SelectedItem is Item selectedItem)
            {
                try
                {
                    selectedItem.Info = _descriptionTextBox.Text;
                    _descriptionTextBox.BackColor = SystemColors.Window;
                }
                catch (ArgumentException ex)
                {
                    _descriptionTextBox.BackColor = Color.Red;
                }
            }
        }
        private void _costTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_itemsListBox.SelectedItem is Item selectedItem)
            {
                if (double.TryParse(_costTextBox.Text, out double cost))
                {
                    try
                    {
                        selectedItem.Cost = cost;
                        _costTextBox.BackColor = SystemColors.Window;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        _costTextBox.BackColor = Color.Red;
                    }
                }
                else
                {
                    _costTextBox.BackColor = Color.Red;
                }
            }
        }
    }
}
