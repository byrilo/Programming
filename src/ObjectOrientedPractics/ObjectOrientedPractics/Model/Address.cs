using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        /// <summary>
        /// Индекс получателя.
        /// </summary>
        private int _index;
        /// <summary>
        /// Страна получателя.
        /// </summary>
        private string _country = string.Empty;
        /// <summary>
        /// Город получателя.
        /// </summary>
        private string _city = string.Empty;
        /// <summary>
        /// Улица получателя.
        /// </summary>
        private string _street = string.Empty;
        /// <summary>
        /// Подьезд получателя.
        /// </summary>
        private string _building = string.Empty;
        /// <summary>
        /// Квартира получателя.
        /// </summary>
        private string _apartment = string.Empty;

        /// <summary>
        /// Свойство для получения и установки индекса. Индекс должен быть шестизначным числом.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Индекс должен быть шестизначным числом.");
                }
                _index = value;
            }
        }

        /// <summary>
        /// Свойство для получения и установки страны. Страна должна быть не длиннее 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Город получателя. Свойство для получения и установки города. Город должен быть не длиннее 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Улица получателя. Свойство для получения и установки улицы. Улица должна быть не длиннее 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Подьезд получателя. Свойство для получения и установки подъезда. Подьезд должен быть не длиннее 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Квартира получателя. Свойство для получения и установки квартиры. Квартира должна быть не длиннее 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }
        /// <summary>
        /// Конструктор класса Address, который инициализирует новый экземпляр адреса с пустыми значениями.
        /// </summary>
        public Address()
        {
        }
        /// <summary>
        /// Конструктор класса Address, который инициализирует новый экземпляр адреса с заданными значениями.
        /// </summary>
        /// <param name="index">Индекс адреса.</param>
        /// <param name="country">Страна адреса.</param>
        /// <param name="city">Город адреса.</param>
        /// <param name="street">Улица адреса.</param>
        /// <param name="building">Номер здания адреса.</param>
        /// <param name="apartment">Номер квартиры адреса.=</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
