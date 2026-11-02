using System.ComponentModel;
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
        /// Заказы всех покупателей. Служат источником данных таблицы.
        /// </summary>
        private BindingList<Order> _orders = new BindingList<Order>();

        /// <summary>
        /// Текущий выбранный заказ.
        /// </summary>
        private Order? _currentOrder;

        /// <summary>
        /// Текущий выбранный заказ как приоритетный. Ссылается на тот же объект, что и
        /// <see cref="_currentOrder"/>, если заказ приоритетный, иначе равен <c>null</c>.
        /// </summary>
        private PriorityOrder? _selectedPriorityOrder;

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
        /// Возвращает и задаёт текущий выбранный заказ. При смене заказа определяет, является ли он
        /// приоритетным, и показывает или скрывает панель настроек приоритетного заказа.
        /// </summary>
        private Order? CurrentOrder
        {
            get { return _currentOrder; }
            set
            {
                _currentOrder = value;
                _selectedPriorityOrder = value as PriorityOrder;
                _priorityOptionsPanel.Visible = _selectedPriorityOrder != null;
            }
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

            // Заполнение выпадающего списка временем доставки приоритетного заказа.
            foreach (string time in PriorityOrder.AvailableDeliveryTimes)
            {
                _deliveryTimeComboBox.Items.Add(time);
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
        /// Собирает заказы всех покупателей в один список и назначает его источником данных таблицы.
        /// Если ранее выбранный заказ ещё существует, он остаётся выбранным.
        /// </summary>
        private void UpdateOrders()
        {
            Order? previousOrder = CurrentOrder;

            List<Order> orders = new List<Order>();
            foreach (Customer customer in _customers)
            {
                orders.AddRange(customer.Orders);
            }

            _orders = new BindingList<Order>(orders);
            _ordersDataGridView.DataSource = _orders;

            int previousIndex = previousOrder == null ? -1 : _orders.IndexOf(previousOrder);
            _ordersDataGridView.ClearSelection();
            if (previousIndex >= 0)
            {
                _ordersDataGridView.Rows[previousIndex].Selected = true;
                ShowOrder(previousOrder);
            }
            else
            {
                ShowOrder(null);
            }
        }

        /// <summary>
        /// Возвращает покупателя, которому принадлежит заказ.
        /// </summary>
        /// <param name="order">Заказ.</param>
        /// <returns>Покупатель или <c>null</c>, если заказ не найден ни у одного покупателя.</returns>
        private Customer? FindCustomer(Order order)
        {
            foreach (Customer customer in _customers)
            {
                if (customer.Orders.Contains(order))
                {
                    return customer;
                }
            }

            return null;
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
        /// Подставляет в таблицу значения, которых нет в самом заказе: имя покупателя и адрес одной строкой.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _ordersDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _orders.Count)
            {
                return;
            }

            Order order = _orders[e.RowIndex];
            if (e.ColumnIndex == _customerColumn.Index)
            {
                e.Value = FindCustomer(order)?.Fullname;
                e.FormattingApplied = true;
            }
            else if (e.ColumnIndex == _addressColumn.Index)
            {
                e.Value = FormatAddress(order.Address);
                e.FormattingApplied = true;
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

            if (_selectedPriorityOrder != null)
            {
                _deliveryTimeComboBox.SelectedItem = _selectedPriorityOrder.DesiredTime;
            }
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

            ShowOrder(_ordersDataGridView.SelectedRows[0].DataBoundItem as Order);
        }

        /// <summary>
        /// Обрабатывает выбор статуса: присваивает его выбранному заказу и обновляет строку таблицы.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _orderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentOrder != null
                && _orderStatusComboBox.SelectedItem is OrderStatus status
                && CurrentOrder.Status != status)
            {
                CurrentOrder.Status = status;

                int index = _orders.IndexOf(CurrentOrder);
                if (index >= 0)
                {
                    _orders.ResetItem(index);
                }
            }
        }

        /// <summary>
        /// Обрабатывает выбор времени доставки: сохраняет его в выбранном приоритетном заказе.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _deliveryTimeComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_selectedPriorityOrder != null
                && _deliveryTimeComboBox.SelectedItem is string time
                && _selectedPriorityOrder.DesiredTime != time)
            {
                _selectedPriorityOrder.DesiredTime = time;
            }
        }
    }
}
