using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Other;

namespace Programming.Model
{
    public class Point2D
    {
        // Свойства доступны для чтения извне, но могут быть установлены только внутри класса
        private int _x;
        public int X
        {
            get => _x;
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }
        private int _y;
        public int Y
        {
            get => _y;
            private set
            {
                _y = value;
            }
        }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
