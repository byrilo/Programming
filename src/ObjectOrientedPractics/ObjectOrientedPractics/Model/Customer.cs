using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname = string.Empty;
        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя. Имя должно быть не длиннее 200 символов.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки покупателя.</param>
        public Customer(string fullname, Address address)
        {
            _id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }
        /// <summary>
        /// Возвращает строковое представление объекта <see cref="Customer"/>.
        /// </summary>
        /// <returns>Имя пользователя.</returns>
        public override string ToString()
        {
            return Fullname;
        }
    }
}
