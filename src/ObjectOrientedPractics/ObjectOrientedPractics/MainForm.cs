using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранилище данных приложения
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        /// Создаёт главное окно и передаёт данные магазина во вкладки.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _itemsTab.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            _ordersTab.Customers = _store.Customers;
        }

        /// <summary>
        /// Обрабатывает переключение вкладок: при переходе на вкладку корзин обновляет её данные,
        /// так как товары и покупатели могли измениться на других вкладках.
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void _tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elem.SelectedTab == Cart)
            {
                cartsTab1.RefreshData();
            }
            else if (elem.SelectedTab == _ordersTabPage)
            {
                _ordersTab.RefreshData();
            }
        }
    }
}
