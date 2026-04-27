using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Предоставляет статические методы для проверки пересечений геометрических фигур:
    /// прямоугольников и колец.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет наличие пересечения между двумя прямоугольниками.
        /// </summary>
        /// <param name="r1">Первый прямоугольник для проверки.</param>
        /// <param name="r2">Второй прямоугольник для проверки.</param>
        /// <returns>Возвращает true, если прямоугольники пересекаются; иначе false.</returns>
        public static bool IsCollision(Rectangle r1, Rectangle r2)
        {
            bool collisionX = Math.Abs(r1.Center.X - r2.Center.X) < (r1.Width / 2.0 + r2.Width / 2.0);
            bool collisionY = Math.Abs(r1.Center.Y - r2.Center.Y) < (r1.Length / 2.0 + r2.Length / 2.0);
            return collisionX && collisionY;
        }

        /// <summary>
        /// Проверяет наличие пересечения между двумя кольцами.
        /// </summary>
        /// <param name="ring1">Первое кольцо для проверки.</param>
        /// <param name="ring2">Второе кольцо для проверки.</param>
        /// <returns>Возвращает true, если кольца пересекаются; иначе false.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dx = ring1.Center.X - ring2.Center.X;
            double dy = ring1.Center.Y - ring2.Center.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);
            double sumRadii = ring1.OuterRadius + ring2.OuterRadius;
            return distance < sumRadii;
        }
    }
}