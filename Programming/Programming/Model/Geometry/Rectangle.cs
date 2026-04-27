using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Other;

namespace Programming.Model
{
    /// <summary>
    /// Представляет прямоугольник с заданными размерами, цветом и позицией центра.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Поле для хранения значения длины прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Поле для хранения значения ширины прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Поле для хранения значения цвета прямоугольника.
        /// </summary>
        private string _color;

        /// <summary>
        /// Поле для хранения порядкового номера прямоугольника.
        /// </summary>
        private int _number;

        /// <summary>
        /// Статическое поле для подсчёта всех созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Возвращает и задаёт значение длины прямоугольника. Должно быть положительным.
        /// </summary>
        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение ширины прямоугольника. Должно быть положительным.
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает общее количество всех созданных прямоугольников.
        /// </summary>
        public static int AllRectanglesCount => _allRectanglesCount;

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника. Доступен только для чтения.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает и задаёт координаты центра прямоугольника в двумерном пространстве.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт значение цвета прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задаёт порядковый номер прямоугольника.
        /// </summary>
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        /// <summary>
        /// Возвращает строковое представление прямоугольника с его порядковым номером.
        /// </summary>
        /// <returns>Возвращает строку формата "Rectangle {Number}".</returns>
        public override string ToString()
        {
            return $"Rectangle {Number}";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/> с указанными параметрами.
        /// </summary>
        /// <param name="length">Длина прямоугольника. Должна быть положительной.</param>
        /// <param name="width">Ширина прямоугольника. Должна быть положительной.</param>
        /// <param name="color">Цвет прямоугольника в виде строки.</param>
        /// <param name="x">Координата X центра прямоугольника.</param>
        /// <param name="y">Координата Y центра прямоугольника.</param>
        public Rectangle(double length, double width, string color, int x, int y)
        {
            _allRectanglesCount++;
            Id = _allRectanglesCount;
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(x, y);
        }
    }
}