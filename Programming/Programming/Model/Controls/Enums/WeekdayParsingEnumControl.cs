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
    public partial class WeekdayParsingEnumControl : UserControl
    {
        public WeekdayParsingEnumControl()
        {
            InitializeComponent();
        }

        private void WeekdayParsingEnumControl_Load(object sender, EventArgs e)
        {

        }
        private void ParseButton_Click(object sender, EventArgs e)
        {
            string input = TextBoxValueParsing.Text; // Считывание текста из TextBoxValueParsing
            if (Enum.TryParse(input, true, out Weekday day)) // Пытаемся перевести введённый текст в Enum Weekday, true позволяет игнорировать регистр
            {
                int IntValue = (int)day; // Если успешно, то загоняем в переменную числовое значение (порядковый номер) элемента
                ResultLabel.Text = $"Это день недели ({day} = {IntValue})"; // Вывод результата

            }
            else
            {
                ResultLabel.Text = "Ошибка! День недели не распознан."; // Сообщение при неверно введённом значении.
            }
        }
    }
}
