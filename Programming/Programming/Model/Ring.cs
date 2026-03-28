using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Ring
    {
        public Point2D Center { get; set; }

        private double _innerRadius;
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));

                // Взаимозависимость 
                if (_outerRadius > 0 && value >= _outerRadius)
                {
                    throw new ArgumentException("Внутренний радиус должен быть меньше внешнего.");
                }
                _innerRadius = value;
            }
        }

        private double _outerRadius;
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));

                // Взаимозависимость
                if (_innerRadius > 0 && value <= _innerRadius)
                {
                    throw new ArgumentException("Внешний радиус должен быть больше внутреннего.");
                }
                _outerRadius = value;
            }
        }

        // Вычисляемое свойство
        public double Area
        {
            get
            {
                return Math.PI * (OuterRadius * OuterRadius - InnerRadius * InnerRadius);
            }
        }

        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            // Присвоение через свойства для запуска валидации
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
    }
}
