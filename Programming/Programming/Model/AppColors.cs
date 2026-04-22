using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Статический класс для хранения всех цветов приложения
    /// </summary>
    public static class AppColors
    {
        // Цвета для валидации
        public static Color ValidInput => Color.White;
        public static Color InvalidInput => Color.LightPink;

        // Цвета для прямоугольников
        public static Color RectangleNormal => Color.FromArgb(127, 127, 255, 127); // Зелёный полупрозрачный
        public static Color RectangleCollision => Color.FromArgb(127, 255, 127, 127); // Красный полупрозрачный

        // Цвета для сезонов
        public static Color SeasonAutumn => ColorTranslator.FromHtml("#e29c45");
        public static Color SeasonSpring => ColorTranslator.FromHtml("#559c45");

        // Можно добавить другие цвета по необходимости
    }
}
