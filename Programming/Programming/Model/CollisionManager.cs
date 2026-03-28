using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class CollisionManager
    {
        // Столкновение прямоугольников 
        public static bool IsCollision(Rectangle r1, Rectangle r2)
        {
            // Разница координат по X меньше суммы половин ширин
            bool collisionX = Math.Abs(r1.Center.X - r2.Center.X) < (r1.Width / 2.0 + r2.Width / 2.0);
            // Разница координат по Y меньше суммы половин высот
            bool collisionY = Math.Abs(r1.Center.Y - r2.Center.Y) < (r1.Length / 2.0 + r2.Length / 2.0);

            return collisionX && collisionY;
        }

        // Столкновение колец 
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            // Расстояние между центрами
            double dx = ring1.Center.X - ring2.Center.X;
            double dy = ring1.Center.Y - ring2.Center.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            // Сумма внешних радиусов
            double sumRadii = ring1.OuterRadius + ring2.OuterRadius;

            return distance < sumRadii;
        }
    }
}
