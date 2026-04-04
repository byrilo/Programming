using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours // Свойство часа
        {
            get => _hours;            
            set 
            { 
                Validator.AssertValueInRange(value, 0, 24, nameof(Hours));
            }
        }
        public int Minutes // Свойство минуты
        {
            get => _minutes;           
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));
            }
        }
        public int Seconds // Свойство секунды
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));
            }
        }
        public Time() { } // Конструкторы
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
