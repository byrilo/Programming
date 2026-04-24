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
        private int _number;

        public int MinutesDuration // Свойство длительности фильма
        {
            get => _minutesDuration;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(MinutesDuration));
                _minutesDuration = value;
            }
        }
        public double Rating // Свойство рейтинга фильма
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Number // Cвойство порядкового номера
        {
            get { return _number; }
            set { _number = value; }
        }
        public override string ToString() // метод ToString для отображения информации о прямоугольнике
        {
            return $"Film {Number}";
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
