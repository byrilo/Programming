using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Other;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;
        private int _number; // Для отображения порядкового номера прямоугольника
        private static int _allRectanglesCount = 0; // Статическое поле для подсчета всех созданных прямоугольников

        public double Length // Свойcтво длины
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }
        public double Width // Свойство ширины
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }
        public static int AllRectanglesCount => _allRectanglesCount; // Статическое свойство для получения количества всех созданных прямоугольников
        public int Id { get; private set; } // Уникальный ID
        public Point2D Center { get; set; } // Свойство центра прямоугольника
        public string Color { get; set; } // Автосвойство
        public int Number // Cвойство порядкового номера
        {
            get { return _number; }
            set { _number = value; }
        }
        public override string ToString() // метод ToString для отображения информации о прямоугольнике
        {
            return $"Rectangle {Number}";
        }
   

        // Конструктор
        public Rectangle(double length, double width, string color, int x, int y)
        {
            // Увеличение счетчика
            _allRectanglesCount++;
            // Присвоение уникального ID
            Id = _allRectanglesCount;
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(x, y);
        }
    }
}
