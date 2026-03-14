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
                    MessageBox.Show("Ошибка. Длина не может иметь отрицательное значение.");
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
                    MessageBox.Show("Ошибка. Ширина не может иметь отрицательное значение");
                }
                _width = value;
            }
        }
        public string Color { get; set; } // Автосвойство

        public Rectangle() { } // Конструкторы?
        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
    }
}
