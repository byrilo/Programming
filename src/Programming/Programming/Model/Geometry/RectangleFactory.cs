using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Предоставляет методы для создания экземпляров класса <see cref="Rectangle"/> 
    /// со случайными параметрами.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Генератор случайных чисел для создания случайных параметров прямоугольника.
        /// </summary>
        private static Random _rnd = new Random();

        /// <summary>
        /// Создаёт прямоугольник со случайными параметрами: размерами, цветом и координатами.
        /// </summary>
        /// <param name="maxX">Максимальное значение координаты X по центру.</param>
        /// <param name="maxY">Максимальное значение координаты Y по центру.</param>
        /// <returns>Возвращает новый экземпляр класса <see cref="Rectangle"/> со случайными параметрами.</returns>
        public static Rectangle Randomize(int maxX = 500, int maxY = 500)
        {
            double length = _rnd.Next(50, 150);
            double width = _rnd.Next(50, 150);
            string color = ((Colors)_rnd.Next(0, Enum.GetValues(typeof(Colors)).Length)).ToString();

            int x = _rnd.Next(15, maxX - 15);
            int y = _rnd.Next(15, maxY - 15);

            return new Rectangle(length, width, color, x, y);
        }
    }
}