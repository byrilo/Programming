using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Other;

namespace Programming.Model
{
    /// <summary>
    /// Представляет точку в двумерном пространстве с координатами X и Y.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Поле для хранения координаты X.
        /// </summary>
        private int _x;

        /// <summary>
        /// Возвращает координату X точки. Доступен для чтения извне, 
        /// но может быть установлен только внутри класса. Должен быть положительным.
        /// </summary>
        public int X
        {
            get => _x;
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Поле для хранения координаты Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает координату Y точки. Доступен для чтения извне, 
        /// но может быть установлен только внутри класса.
        /// </summary>
        public int Y
        {
            get => _y;
            private set
            {
                _y = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/> с указанными координатами.
        /// </summary>
        /// <param name="x">Координата X. Должна быть положительной.</param>
        /// <param name="y">Координата Y.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}