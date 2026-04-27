using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programming.Model
{
    /// <summary>
    /// Представляет информацию о фильме: название, длительность, год создания, жанр и рейтинг.
    /// </summary>
    public class Film
    {
        /// <summary>
        /// Поле для хранения названия фильма.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле для хранения длительности фильма в минутах.
        /// </summary>
        private int _minutesDuration;

        /// <summary>
        /// Поле для хранения года создания фильма.
        /// </summary>
        private int _yearOfCreation;

        /// <summary>
        /// Поле для хранения жанра фильма.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Поле для хранения рейтинга фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Поле для хранения порядкового номера фильма.
        /// </summary>
        private int _number;

        /// <summary>
        /// Возвращает и задаёт длительность фильма в минутах. Должно быть положительным числом.
        /// </summary>
        public int MinutesDuration
        {
            get => _minutesDuration;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(MinutesDuration));
                _minutesDuration = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Должен находиться в диапазоне от 0 до 10.
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Возвращает и задаёт порядковый номер фильма.
        /// </summary>
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        /// <summary>
        /// Возвращает строковое представление фильма с его порядковым номером.
        /// </summary>
        /// <returns>Возвращает строку формата "Film {Number}".</returns>
        public override string ToString()
        {
            return $"Film {Number}";
        }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт год создания фильма.
        /// </summary>
        public int YearOfCreation { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Film"/> со значениями по умолчанию.
        /// </summary>
        public Film() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Film"/> с указанными параметрами.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="minutesduration">Длительность фильма в минутах. Должна быть положительной.</param>
        /// <param name="yearofcreation">Год создания фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма. Должен находиться в диапазоне от 0 до 10.</param>
        public Film(string name, int minutesduration, int yearofcreation, string genre, double rating)
        {
            Name = name;
            MinutesDuration = minutesduration;
            YearOfCreation = yearofcreation;
            Genre = genre;
            Rating = rating;
        }
    }
}