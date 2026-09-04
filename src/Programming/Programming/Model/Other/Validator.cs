using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Предоставляет статические методы для валидации данных: проверка положительных значений 
    /// и значений в заданном диапазоне.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что целое число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="PropertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если значение меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(int value, string PropertyName = " ")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Ошибка. {PropertyName} должно быть положительным числом.");
            }
        }

        /// <summary>
        /// Проверяет, что вещественное число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="PropertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если значение меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(double value, string PropertyName = " ")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Ошибка. {PropertyName} должно быть положительным числом.");
            }
        }

        /// <summary>
        /// Проверяет, что целое число находится в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное допустимое значение.</param>
        /// <param name="max">Максимальное допустимое значение.</param>
        /// <param name="PropertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если значение выходит за пределы диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string PropertyName = " ")
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Ошибка. {PropertyName} должно быть в диапазоне от {min} до {max}.");
            }
        }

        /// <summary>
        /// Проверяет, что вещественное число находится в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное допустимое значение.</param>
        /// <param name="max">Максимальное допустимое значение.</param>
        /// <param name="PropertyName">Имя свойства для сообщения об ошибке.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если значение выходит за пределы диапазона.</exception>
        public static void AssertValueInRange(double value, double min, double max, string PropertyName = " ")
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Ошибка. {PropertyName} должно быть в диапазоне от {min} до {max}.");
            }
        }
    }
}