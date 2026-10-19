using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        /// <summary>
        /// Поле для хранения списка товаров в корзине.
        /// </summary>
        private List<Item> _items = new List<Item>();
        /// <summary>
        /// Получает и задает список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        /// <summary>
        /// Получает общую стоимость товаров в корзине.
        /// </summary>
        public double Amount
        {
            get 
            {
                if (_items == null)
                {
                    return 0.0;
                }
                double sum = 0.0;
                foreach (var item in _items)
                {
                    sum += item.Cost;
                }
                return sum;
            }
        }
    }
}

