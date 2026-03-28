using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        // Значение для целых чисел
        public static void AssertOnPositiveValue(int value, string PropertyName = "")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Ошибка. {PropertyName} должно быть положительным числом.");
            }
        }
        // Значения для вещественных чисел
        public static void AssertOnPositiveValue(double value, string PropertyName = "")
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Ошибка. {PropertyName} должно быть положительным числом.");
            }
        }
        // Диапазон для целых чисел
        public static void AssertValueInRange(int value, int min, int max, string PropertyName = "")
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Ошибка. {PropertyName} должно быть в диапазоне от {min} до {max}.");
            }
        }
        // Диапазон для вещественных чисел
        public static void AssertValueInRange(double value, double min, double max, string PropertyName = "")
        {
                if (value < min || value > max)
                {
                    throw new ArgumentException($"Ошибка. {PropertyName} должно быть в диапазоне от {min} до {max}.");
                }
        }
    }
}
