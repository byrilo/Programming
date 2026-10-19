using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для управления корзинами покупателей.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer? _currentCustomer;

        /// <summary>
        /// Возвращает и задаёт список товаров, отображаемых на вкладке.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                _itemsListBox.DataSource = _items;
            }
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей, отображаемых на вкладке.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                _customerComboBox.DataSource = _customers;
                _customerComboBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Возвращает и задаёт текущего выбранного покупателя.
        /// </summary>
        private Customer? CurrentCustomer
        {
            get { return _currentCustomer; }
            set { _currentCustomer = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет данные вкладки по текущим спискам товаров и покупателей:
        /// перезаполняет список товаров и выпадающий список покупателей, сохраняя выбранного
        /// покупателя, если он остался в списке, и обновляет его корзину и стоимость.
        /// </summary>
        public void RefreshData()
        {
            Customer? previousCustomer = CurrentCustomer;

            _itemsListBox.DataSource = null;
            _itemsListBox.DataSource = _items;

            _customerComboBox.DataSource = null;
            _customerComboBox.DataSource = _customers;
            _customerComboBox.SelectedIndex = previousCustomer == null ? -1 : _customers.IndexOf(previousCustomer);

            CurrentCustomer = _customerComboBox.SelectedItem as Customer;
            UpdateCart();
        }

        /// <summary>
        /// Обрабатывает выбор покупателя в выпадающем списке и показывает товары его корзины.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = _customerComboBox.SelectedItem as Customer;
            UpdateCart();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки добавления выбранного товара в корзину текущего покупателя.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _addToCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null && _itemsListBox.SelectedItem is Item selectedItem)
            {
                CurrentCustomer.Cart.Items.Add(selectedItem);
                UpdateCart();
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки удаления выбранного товара из корзины текущего покупателя.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _removeItemButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null && _cartListBox.SelectedItem is Item selectedItem)
            {
                CurrentCustomer.Cart.Items.Remove(selectedItem);
                UpdateCart();
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки очистки корзины текущего покупателя.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _clearCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Clear();
                UpdateCart();
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки создания заказа: переносит товары из корзины
        /// текущего покупателя в новый заказ, добавляет заказ покупателю и очищает корзину.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _createOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null && CurrentCustomer.Cart.Items.Count > 0)
            {
                var order = new Order(CurrentCustomer.Address, CurrentCustomer.Cart.Items);
                CurrentCustomer.Orders.Add(order);
                CurrentCustomer.Cart.Items.Clear();
                UpdateCart();
            }
        }

        /// <summary>
        /// Обновляет отображение корзины текущего покупателя: список товаров и общую стоимость.
        /// Если покупатель не выбран, список пуст, а стоимость равна нулю.
        /// </summary>
        private void UpdateCart()
        {
            _cartListBox.DataSource = null;
            if (CurrentCustomer != null)
            {
                _cartListBox.DataSource = CurrentCustomer.Cart.Items;
                _amountValueLabel.Text = CurrentCustomer.Cart.Amount.ToString("N2");
            }
            else
            {
                _amountValueLabel.Text = 0.0.ToString("N2");
            }
        }
    }
}
