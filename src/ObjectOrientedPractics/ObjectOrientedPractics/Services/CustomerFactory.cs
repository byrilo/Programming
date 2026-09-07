using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет метод для генеорации случайных товаров
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Возможные имена покупателей
        /// </summary>
        private static readonly string[] _fullnames =
        {
            "Иванов Пётр Сергеевич",
            "Смирнова Анна Викторовна",
            "Кузнецов Дмитрий Александрович",
            "Попова Екатерина Игоревна",
            "Васильев Никита Романович",
            "Соколова Мария Дмитриевна",
            "Морозов Артём Олегович",
            "Новикова Дарья Андреевна"
        };
        /// <summary>
        /// Возможные адреса покупателей
        /// </summary>
        private static readonly string[] _addresses =
        {
            "г. Москва, ул. Тверская, д. 12, кв. 45",
            "г. Санкт-Петербург, Невский пр-т, д. 78, кв. 10",
            "г. Казань, ул. Баумана, д. 5",
            "г. Новосибирск, ул. Ленина, д. 23, кв. 67",
            "г. Екатеринбург, ул. Малышева, д. 31",
            "г. Нижний Новгород, ул. Большая Покровская, д. 9, кв. 3"
        }; 
        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Возвращает случайно сгенерированный товар
        /// </summary>
        /// <returns></returns>
        public static Customer GetRandomCustomer()
        {
            string fullname = _fullnames[_random.Next(_fullnames.Length)];
            string address = _addresses[_random.Next(_addresses.Length)];
            return new Customer(fullname, address);
        }
    }
}
