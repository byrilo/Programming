using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Статический класс для хранения всех цветов приложения, используемых для валидации, 
    /// индикации пересечений и визуального оформления элементов управления.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Возвращает цвет фона для поля с корректно введёнными данными.
        /// </summary>
        public static Color ValidInput => Color.White;

        /// <summary>
        /// Возвращает цвет фона для поля с ошибкой валидации.
        /// </summary>
        public static Color InvalidInput => Color.LightPink;

        /// <summary>
        /// Возвращает цвет фона для прямоугольника, не имеющего пересечений с другими.
        /// </summary>
        public static Color RectangleNormal => Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Возвращает цвет фона для прямоугольника, имеющего пересечение с другим прямоугольником.
        /// </summary>
        public static Color RectangleCollision => Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Возвращает цвет фона, соответствующий осеннему сезону.
        /// </summary>
        public static Color SeasonAutumn => ColorTranslator.FromHtml("#e29c45");

        /// <summary>
        /// Возвращает цвет фона, соответствующий весеннему сезону.
        /// </summary>
        public static Color SeasonSpring => ColorTranslator.FromHtml("#559c45");
    }
}