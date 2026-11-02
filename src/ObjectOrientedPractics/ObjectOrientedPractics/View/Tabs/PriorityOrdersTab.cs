using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для работы с одним приоритетным заказом.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Список товаров, из которых добавляются случайные товары в заказ.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Приоритетный заказ, с которым работает вкладка.
        /// </summary>
        private PriorityOrder _order;

        /// <summary>
        /// Генератор случайных чисел для выбора товара.
        /// </summary>
        private readonly Random _random = new Random();

        /// <summary>
        /// Возвращает и задаёт список товаров, доступных для добавления в заказ.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();

            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
            {
                _orderStatusComboBox.Items.Add(status);
            }

            foreach (string time in PriorityOrder.AvailableDeliveryTimes)
            {
                _deliveryTimeComboBox.Items.Add(time);
            }

            _order = CreateOrder();
            ShowOrder();
        }

        /// <summary>
        /// Создаёт новый пустой приоритетный заказ.
        /// </summary>
        /// <returns>Новый приоритетный заказ.</returns>
        private static PriorityOrder CreateOrder()
        {
            return new PriorityOrder(
                new Address(),
                new List<Item>(),
                DateTime.Today,
                PriorityOrder.AvailableDeliveryTimes[0]);
        }

        /// <summary>
        /// Показывает данные текущего заказа на вкладке.
        /// </summary>
        private void ShowOrder()
        {
            _orderIdTextBox.Text = _order.Id.ToString();
            _orderCreatedTextBox.Text = _order.Created.ToString("dd.MM.yyyy HH:mm");
            _orderStatusComboBox.SelectedItem = _order.Status;
            _deliveryTimeComboBox.SelectedItem = _order.DesiredTime;
            _orderAddressControl.Address = _order.Address;
            UpdateItems();
        }

        /// <summary>
        /// Обновляет список товаров заказа и общую стоимость.
        /// </summary>
        private void UpdateItems()
        {
            _orderItemsListBox.DataSource = null;
            _orderItemsListBox.DataSource = _order.Items;
            _orderAmountValueLabel.Text = _order.Amount.ToString("N2");
        }

        /// <summary>
        /// Обрабатывает выбор статуса: присваивает его заказу.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _orderStatusComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_orderStatusComboBox.SelectedItem is OrderStatus status)
            {
                _order.Status = status;
            }
        }

        /// <summary>
        /// Обрабатывает выбор времени доставки: присваивает его заказу.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _deliveryTimeComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_deliveryTimeComboBox.SelectedItem is string time)
            {
                _order.DesiredTime = time;
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки добавления: добавляет в заказ случайный товар.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _addItemButton_Click(object? sender, EventArgs e)
        {
            if (_items.Count == 0)
            {
                return;
            }

            _order.Items.Add(_items[_random.Next(_items.Count)]);
            UpdateItems();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки удаления: удаляет выбранный товар и выбирает следующий
        /// на его месте или, если следующего нет, последний товар списка.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _removeItemButton_Click(object? sender, EventArgs e)
        {
            int index = _orderItemsListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            _order.Items.RemoveAt(index);
            UpdateItems();

            if (_order.Items.Count > 0)
            {
                _orderItemsListBox.SelectedIndex = Math.Min(index, _order.Items.Count - 1);
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки очистки: создаёт новый заказ вместо старого.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _clearOrderButton_Click(object? sender, EventArgs e)
        {
            _order = CreateOrder();
            ShowOrder();
        }
    }
}
