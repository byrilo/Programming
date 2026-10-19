using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для просмотра всех заказов и изменения их статуса.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей, чьи заказы отображаются на вкладке.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Общий список заказов всех покупателей. Порядок совпадает с порядком строк в таблице.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Текущий выбранный заказ.
        /// </summary>
        private Order? _currentOrder;

        /// <summary>
        /// Возвращает и задаёт список покупателей, заказы которых отображаются на вкладке.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateOrders();
            }
        }

        /// <summary>
        /// Возвращает и задаёт текущий выбранный заказ.
        /// </summary>
        private Order? CurrentOrder
        {
            get { return _currentOrder; }
            set { _currentOrder = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            // Заполнение выпадающего списка статусами заказа.
            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
            {
                _orderStatusComboBox.Items.Add(status);
            }

            // Все данные заказа, кроме статуса, на панели только для чтения.
            _orderAddressControl.ReadOnly = true;
        }

        /// <summary>
        /// Обновляет данные вкладки по текущему списку покупателей.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Собирает заказы всех покупателей в один список и перезаполняет таблицу.
        /// Если ранее выбранный заказ ещё существует, он остаётся выбранным.
        /// </summary>
        private void UpdateOrders()
        {
            Order? previousOrder = CurrentOrder;

            _ordersDataGridView.Rows.Clear();
            _orders.Clear();

            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                {
                    _orders.Add(order);
                    _ordersDataGridView.Rows.Add(
                        order.Id,
                        order.Created,
                        customer.Fullname,
                        FormatAddress(order.Address),
                        order.Amount,
                        order.Status);
                }
            }

            int previousIndex = previousOrder == null ? -1 : _orders.IndexOf(previousOrder);
            if (previousIndex >= 0)
            {
                _ordersDataGridView.Rows[previousIndex].Selected = true;
                ShowOrder(previousOrder);
            }
            else
            {
                _ordersDataGridView.ClearSelection();
                ShowOrder(null);
            }
        }

        /// <summary>
        /// Показывает данные заказа на правой панели. Если заказ не выбран, панель очищается.
        /// </summary>
        /// <param name="order">Заказ для отображения или <c>null</c>.</param>
        private void ShowOrder(Order? order)
        {
            CurrentOrder = order;

            if (order == null)
            {
                _orderIdTextBox.Clear();
                _orderCreatedTextBox.Clear();
                _orderStatusComboBox.SelectedIndex = -1;
                _orderAddressControl.Address = new Address();
                _orderItemsListBox.DataSource = null;
                _orderAmountValueLabel.Text = 0.0.ToString("N2");
                return;
            }

            _orderIdTextBox.Text = order.Id.ToString();
            _orderCreatedTextBox.Text = order.Created.ToString("dd.MM.yyyy HH:mm");
            _orderStatusComboBox.SelectedItem = order.Status;
            _orderAddressControl.Address = order.Address;
            _orderItemsListBox.DataSource = null;
            _orderItemsListBox.DataSource = order.Items;
            _orderAmountValueLabel.Text = order.Amount.ToString("N2");
        }

        /// <summary>
        /// Формирует адрес доставки в виде одной строки, пропуская незаполненные части.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <returns>Адрес одной строкой.</returns>
        private static string FormatAddress(Address address)
        {
            string index = address.Index > 0 ? address.Index.ToString() : string.Empty;
            string[] parts =
            {
                index,
                address.Country,
                address.City,
                address.Street,
                address.Building,
                address.Apartment
            };

            return string.Join(", ", parts.Where(part => !string.IsNullOrWhiteSpace(part)));
        }

        /// <summary>
        /// Обрабатывает выбор строки в таблице заказов и показывает выбранный заказ на панели справа.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_ordersDataGridView.SelectedRows.Count == 0)
            {
                ShowOrder(null);
                return;
            }

            int index = _ordersDataGridView.SelectedRows[0].Index;
            ShowOrder(index < _orders.Count ? _orders[index] : null);
        }

        /// <summary>
        /// Обрабатывает выбор статуса: присваивает его выбранному заказу и обновляет строку таблицы.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _orderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentOrder != null && _orderStatusComboBox.SelectedItem is OrderStatus status)
            {
                CurrentOrder.Status = status;

                int index = _orders.IndexOf(CurrentOrder);
                if (index >= 0)
                {
                    _ordersDataGridView.Rows[index].Cells[_statusColumn.Index].Value = status;
                }
            }
        }
    }
}
