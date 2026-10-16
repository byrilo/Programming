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

    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Обёртка над списком <see cref="_items"/>, привязанная к <c>ListBox</c> через DataSource.
        /// Работает с тем же списком, поэтому добавлять и удалять товары нужно через неё:
        /// тогда <c>ListBox</c> узнаёт об изменениях и сам обновляется.
        /// </summary>
        private BindingList<Item> _bindingItems;

        /// <summary>
        /// Возвращает и задаёт список товаров, отображаемых на вкладке.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                _bindingItems = new BindingList<Item>(_items);
                _itemsListBox.DataSource = _bindingItems;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            _bindingItems = new BindingList<Item>(_items);
            _itemsListBox.DataSource = _bindingItems;

            // Заполнение комбобокса категориями товаров.
            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                _itemsCategoryComboBox.Items.Add(category);
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки добавления товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _addButton_Click(object sender, EventArgs e)
        {
            var item = new Item("Item", "", 0, Category.Other);
            _bindingItems.Add(item);
            _itemsListBox.SelectedItem = item;
        }
        /// <summary>
        /// Обрабатывает нажатие кнопки удаления товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _removeButton_Click(object sender, EventArgs e)
        {
            if (_itemsListBox.SelectedItem is Item selectedItem)
            {
                _bindingItems.Remove(selectedItem);
            }
        }
        /// <summary>
        /// Обрабатывает выбранный товар
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_itemsListBox.SelectedItem is Item selectedItem)
            {
                _idTextBox.Text = selectedItem.Id.ToString();
                _nameTextBox.Text = selectedItem.Name;
                _descriptionTextBox.Text = selectedItem.Info;
                _costTextBox.Text = selectedItem.Cost.ToString();
                _itemsCategoryComboBox.SelectedItem = selectedItem.Category;
            }
            else
            {
                _idTextBox.Clear();
                _nameTextBox.Clear();
                _descriptionTextBox.Clear();
                _costTextBox.Clear();
                _itemsCategoryComboBox.SelectedIndex = -1;
            }
        }
        /// <summary>
        /// Обрабатывает изменения наименования товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_itemsListBox.SelectedItem is Item selectedItem)
            {
                try
                {
                    selectedItem.Name = _nameTextBox.Text;
                    _nameTextBox.BackColor = SystemColors.Window;

                    // Сообщаем списку, что элемент изменился, чтобы он обновил отображаемое название.
                    _bindingItems.ResetItem(_itemsListBox.SelectedIndex);
                }
                catch (ArgumentException)
                {
                    _nameTextBox.BackColor = Color.Red;
                }
            }
        }
        /// <summary>
        /// Обрабатывает изменение описания товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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
        /// <summary>
        /// Обрабатывает изменение цены товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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
        /// <summary>
        /// Обрабатывает нажатие кнопки случайных значений товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _itemsRandomButton_Click(object sender, EventArgs e)
        {
            var item = ItemFactory.GetRandomItem();
            _bindingItems.Add(item);
            _itemsListBox.SelectedItem = item;
        }
        /// <summary>
        /// Проверка выбранной категории товара и присвоение её выбранному товару.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _itemsCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_itemsCategoryComboBox.SelectedItem is Category selectedCategory && _itemsListBox.SelectedItem is Item selectedItem)
            {
                selectedItem.Category = selectedCategory;
            }
        }
    }
}
