using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для проверки значений свойств объектов.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что длина строки не превышает максимальное значение.
        /// </summary>
        /// <param name="value"> Проверяемое значение </param>
        /// <param name="maxLength"> Максимальная длина строки </param>
        /// <param name="propertyName"> Название свойства </param>
        /// <exception cref="ArgumentException"> Выбрасывается, если длина строки превышает максимальное значение </exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
            }
        }
    }
}
