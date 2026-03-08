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
            get 
            { 
                return _hours; 
            } 
            set 
            { 
                if (value < 0 && value > 23)
                {
                    MessageBox.Show("Ошибка. Неккоректное кол-во часов.");
                    _hours = value;
                }
            }
        }
        public int Minutes // Свойство минуты
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value < 0 && value > 60)
                {
                    MessageBox.Show("Ошибка. Неккоректное кол-во минут.");
                    _minutes = value;
                }
            }
        }
        public int Seconds // Свойство секунды
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value < 0 && value > 60)
                {
                    MessageBox.Show("Ошибка. Неккоректное кол-во секунд.");
                    _seconds = value;
                }
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
