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
    /// <summary>
    /// Представляет пользовательский элемент управления для работы с перечислениями:
    /// отображение значений перечислений и получение их числового представления.
    /// </summary>
    public partial class EnumarationsEnumControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="EnumarationsEnumControl"/>.
        /// </summary>
        public EnumarationsEnumControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке перечислений.
        /// Заполняет список значений выбранным перечислением.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            string selectedEnum = EnumsListBox.SelectedItem.ToString();
            Array enumValues;

            switch (selectedEnum)
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
            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке значений.
        /// Отображает числовое представление выбранного значения перечисления.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem != null)
            {
                var selectedValue = ValuesListBox.SelectedItem;
                int intValue = (int)selectedValue;
                IntValueTextBox.Text = intValue.ToString();
            }
        }
    }
}