using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        /// <summary>
        /// Товары магазина.
        /// </summary>
        private List<Item> _items = new();
        /// <summary>
        /// Покупатели магазина.
        /// </summary>
        private List<Customer> _customers = new();
        /// <summary>
        /// Свойство для доступа к списку товаров магазина.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        /// <summary>
        /// Свойство для доступа к списку покупателей магазина.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        /// <summary>
        /// Создаёт пустой экземпляр класса Store.
        /// </summary>
        public Store() { }
    } 
}
