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
        private static readonly Address[] _addresses =
        {
        new Address(101000, "Россия", "Москва", "Тверская", "12", "45"),
        new Address(190000, "Россия", "Санкт-Петербург", "Невский проспект", "78", "10"),
        new Address(420000, "Россия", "Казань", "Баумана", "5", "1"),
        new Address(630000, "Россия", "Новосибирск", "Ленина", "23", "67"),
        new Address(620000, "Россия", "Екатеринбург", "Малышева", "31", "2"),
        new Address(603000, "Россия", "Нижний Новгород", "Большая Покровская", "9", "3")
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
            Address address = _addresses[_random.Next(_addresses.Length)];
            return new Customer(fullname, address);
        }
    }
}
