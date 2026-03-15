using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programming.Model
{
    public class Film
    {
        private string _name;
        private int _minutesDuration;
        private int _yearOfCreation;
        private string _genre;
        private double _rating;

        public int MinutesDuration // Свойство длительности фильма
        {
            get
            {
                return _minutesDuration;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Ошибка. Длина фильма не может иметь отрицвтельное значение.");
                }
                _minutesDuration = value;
            }
        }
        public double Rating // Свойство рейтинга фильма
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 && value > 10)
                {
                    throw new ArgumentException("Ошибка. Рейтинг может принимать значение от 0 до 10.");
                }
                _rating = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        // Автосвойства
        public string Genre { get; set; }
        public int YearOfCreation { get; set; }
        public Film() { } // Конструкторы
        public Film(string name, int minutesduration, int yearofcreation, string genre, double rating)
        {
            Name = Name;
            MinutesDuration = minutesduration;
            YearOfCreation = yearofcreation;
            Genre = genre;
            Rating = rating;
        }
    }
}
