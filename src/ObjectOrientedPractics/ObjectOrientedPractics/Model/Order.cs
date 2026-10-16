using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Заказ покупателя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата и время создания заказа.
        /// </summary>
        private readonly DateTime _created;

        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Состояние заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает дату и время создания заказа.
        /// </summary>
        public DateTime Created
        {
            get { return _created; }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки заказа.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает и задаёт список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задаёт состояние заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Возвращает общую стоимость товаров в заказе.
        /// Если список товаров пуст или равен null, возвращает 0.0.
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

        /// <summary>
        /// Создаёт новый заказ со статусом <see cref="OrderStatus.New"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">
        /// Товары заказа. В заказ копируется список ссылок на товары, поэтому
        /// последующая очистка исходного списка (например, корзины) не влияет на заказ,
        /// а сами товары остаются теми же объектами, что и в магазине.
        /// </param>
        public Order(Address address, List<Item> items)
        {
            _id = IdGenerator.GetNextId();
            _created = DateTime.Now;
            Address = address;
            Items = new List<Item>(items);
            Status = OrderStatus.New;
        }
    }
}
