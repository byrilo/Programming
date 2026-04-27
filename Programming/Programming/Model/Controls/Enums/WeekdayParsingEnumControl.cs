using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model.Controls.Enums
{
    /// <summary>
    /// Представляет пользовательский элемент управления для парсинга строкового значения 
    /// в перечисление <see cref="Weekday"/> и отображения его числового представления.
    /// </summary>
    public partial class WeekdayParsingEnumControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="WeekdayParsingEnumControl"/>.
        /// </summary>
        public WeekdayParsingEnumControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события загрузки элемента управления.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void WeekdayParsingEnumControl_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Обработчик события нажатия кнопки парсинга.
        /// Пытается преобразовать введённую строку в значение перечисления <see cref="Weekday"/> 
        /// и отображает результат с числовым представлением дня недели.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            string input = TextBoxValueParsing.Text;

            if (Enum.TryParse(input, true, out Weekday day))
            {
                int intValue = (int)day;
                ResultLabel.Text = $"Это день недели ({day} = {intValue})";
            }
            else
            {
                ResultLabel.Text = "Ошибка! День недели не распознан.";
            }
        }
    }
}