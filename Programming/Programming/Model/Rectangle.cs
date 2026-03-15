using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;
        private int _number; // Для отображения порядкового номера прямоугольника

        public double Length // Свойcтво длины
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ошибка. Длина не может иметь отрицательное значение.");
                }
                _length = value;
            }
        }
        public double Width // Свойство ширины
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ширина не может быть отрицательной");
                }
                _width = value;
            }
        }
        public string Color { get; set; } // Автосвойство
        public int Number // Cвойство порядкового номера
        {
            get { return _number; }
            set { _number = value; }
        }
        public override string ToString() // Переписанный метод ToString для отображения информации о прямоугольнике
        {
            return $"Rectangle {Number}";
        }


        public Rectangle() { } // Конструкторы?
        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
    }
}
