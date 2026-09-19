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
        public MainForm()
        {
            InitializeComponent();
            _itemsTab.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }
    }
}
