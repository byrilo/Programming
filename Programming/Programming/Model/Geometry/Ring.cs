using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Other;

namespace Programming.Model
{
    /// <summary>
    /// Представляет кольцо с внутренним и внешним радиусом, имеющее центр в точке 2D.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Возвращает и задаёт центр кольца в двумерном пространстве.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Поле для хранения значения внутреннего радиуса.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Возвращает и задаёт значение внутреннего радиуса кольца.
        /// Должен быть положительным и меньше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));

                if (_outerRadius > 0 && value >= _outerRadius)
                {
                    throw new ArgumentException("Внутренний радиус должен быть меньше внешнего.");
                }
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Поле для хранения значения внешнего радиуса.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задаёт значение внешнего радиуса кольца.
        /// Должен быть положительным и больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));

                if (_innerRadius > 0 && value <= _innerRadius)
                {
                    throw new ArgumentException("Внешний радиус должен быть больше внутреннего.");
                }
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца, вычисленную как разность площадей внешнего и внутреннего кругов.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (OuterRadius * OuterRadius - InnerRadius * InnerRadius);
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/> с указанными параметрами.
        /// </summary>
        /// <param name="center">Центр кольца в двумерном пространстве.</param>
        /// <param name="innerRadius">Внутренний радиус кольца. Должен быть положительным.</param>
        /// <param name="outerRadius">Внешний радиус кольца. Должен быть больше внутреннего радиуса.</param>
        public Ring(Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
    }
}