using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Other;

namespace Programming.Model.Controls
{
    public partial class EnumarationsEnumControl : UserControl
    {
        public EnumarationsEnumControl()
        {
            InitializeComponent();
        }

        private void EnumarationsEnumControl_Load(object sender, EventArgs e)
        {

        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear(); // Очистка ValuesListBox после нового выбора в EnumsListBox
            string selectedEnum = EnumsListBox.SelectedItem.ToString(); //Определение выбранной строки из EnumsListBox
            Array enumValues; // Массив значений перечеслений

            switch (selectedEnum) // значение - массив
            {
                case "Colors":
                    enumValues = Enum.GetValues(typeof(Colors));
                    break;
                case "StudyForm":
                    enumValues = Enum.GetValues(typeof(StudyForm));
                    break;
                case "Genre":
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;
                case "PhoneCreatoes":
                    enumValues = Enum.GetValues(typeof(PhoneCreators));
                    break;
                case "Seasons":
                    enumValues = Enum.GetValues(typeof(Seasons));
                    break;
                case "Weekday":
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    return;
            }
            foreach (var value in enumValues) //добавление значений в ValuesListBox
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem != null) // Проверка на то, что действительно выбран элемент
            {
                var selectedValue = ValuesListBox.SelectedItem; // Получение значения
                int intValue = (int)selectedValue; // Преобразование в Int
                IntValueTextBox.Text = intValue.ToString(); // Вывод значения
            }
        }
    }
}
