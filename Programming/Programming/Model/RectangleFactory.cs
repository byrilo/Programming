using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class RectangleFactory
    {
        private static Random _rnd = new Random();

        public static Rectangle Randomize(int maxX = 500, int maxY = 500)
        {
            double length = _rnd.Next(50, 150);
            double width = _rnd.Next(50, 150);
            string color = ((Colors)_rnd.Next(0, Enum.GetValues(typeof(Colors)).Length)).ToString();

            // Генерация координат внутри канвы с отступом 15 пикселей
            int x = _rnd.Next(15, maxX - 15);
            int y = _rnd.Next(15, maxY - 15);

            return new Rectangle(length, width, color, x, y);
        }
    }
}
