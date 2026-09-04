using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Other;

namespace Programming.Model
{
    /// <summary>
    /// Представляет время с точностью до секунды: часы, минуты и секунды.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Поле для хранения значения часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Поле для хранения значения минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Поле для хранения значения секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задаёт значение часов. Должно находиться в диапазоне от 0 до 24.
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertValueInRange(value, 0, 24, nameof(Hours));
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение минут. Должно находиться в диапазоне от 0 до 60.
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение секунд. Должно находиться в диапазоне от 0 до 60.
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/> со значениями по умолчанию.
        /// </summary>
        public Time() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/> с указанными значениями времени.
        /// </summary>
        /// <param name="hours">Значение часов (0–24).</param>
        /// <param name="minutes">Значение минут (0–60).</param>
        /// <param name="seconds">Значение секунд (0–60).</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}