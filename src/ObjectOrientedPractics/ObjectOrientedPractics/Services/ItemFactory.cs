using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет метод для генерации случайных товаров
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Возможные названия товаров
        /// </summary>
        private static readonly string[] _names = 
        {
            "Беспроводные наушники",
            "Смартфон",
            "Ноутбук",
            "Умные часы",
            "Портативная колонка",
            "Внешний аккумулятор",
            "Клавиатура механическая",
            "Веб-камера"
        };
        /// <summary>
        /// Возможные описания товаров
        /// </summary>
        private static readonly string[] _infos =
        {
            "Качественный товар с гарантией производителя 12 месяцев.",
            "Компактный и лёгкий, подходит для повседневного использования.",
            "Высокая производительность и стильный дизайн.",
            "Долгое время автономной работы от одного заряда.",
            "Совместим с большинством современных устройств."
        };

        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Возвращает случайно сгенерированный товар
        /// </summary>
        /// <returns></returns>
        public static Item GetRandomItem()
        {
            string name = _names[_random.Next(_names.Length)];
            string info = _infos[_random.Next(_infos.Length)];
            double cost = _random.Next(0, 100000);
            return new Item(name, info, cost);
        }
    }
}
