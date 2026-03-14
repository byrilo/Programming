using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;

namespace Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeRectanglesData();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void IntValueTextBox_TextChanged(object sender, EventArgs e)
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

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (ComboBoxSeason.SelectedItem == null) // Проверка на то, что элемент выбран
            {
                MessageBox.Show("Ошибка. Выберите сезон.");
                return;
            }
            string selectedText = ComboBoxSeason.SelectedItem.ToString(); // Получение текста выбранного элемента
            Seasons SelectedSeasons = (Seasons)Enum.Parse(typeof(Seasons), selectedText); // Преобразование строки в тип seasons
            switch (SelectedSeasons) // Различные действия для различных выборов
            {
                case Seasons.Summer:
                    MessageBox.Show("Астрологи объявляют месяц Лета! Население всех жилищ возросло.");
                    break;
                case Seasons.Winter:
                    MessageBox.Show("Идём лепить снеговика!");
                    break;
                case Seasons.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Seasons.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                default: 
                    break;
            }
        }

        private void ComboBoxSeason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Programming.Model.Rectangle[] _rectangles;
        private Programming.Model.Rectangle _currentRectangle;

        private void InitializeRectanglesData()
        {
            Random rnd = new Random();
            _rectangles = new Programming.Model.Rectangle[5];

            // Генерация 5 случайных прямоугольников
            for (int i = 0; i < _rectangles.Length; i++)
            {
                // Генерируем значения от 1 до 100
                double length = rnd.Next(1, 100);
                double width = rnd.Next(1, 100);
                string color = rnd.Next(0, 2) == 0 ? "Red" : "Blue"; // Случайный цвет для примера

                // Создаем объект (сработают проверки в свойствах)
                _rectangles[i] = new Programming.Model.Rectangle(length, width, color);

                // Пункт 13: Добавляем объект в ListBox
                // Благодаря ToString() в списке отобразится понятный текст
                RectangleClassesListBox.Items.Add(_rectangles[i]);
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, что элемент действительно выбран
            if (RectangleClassesListBox.SelectedIndex < 0) return;

            // Пункт 14: Получаем объект из массива по индексу
            _currentRectangle = _rectangles[RectangleClassesListBox.SelectedIndex];

            // Пункт 15: Заполняем TextBox значениями полей объекта
            // Используем безопасное преобразование к строке
            RectangleClassesTextBoxLenght.Text = _currentRectangle.Length.ToString();
            RectangleClassesTextBoxWidth.Text = _currentRectangle.Width.ToString();
            RectangleClassesTextBoxColor.Text = _currentRectangle.Color;

            // Сбрасываем цвет фона на белый (на случай, если ранее была ошибка)
            RectangleClassesTextBoxLenght.BackColor = Color.White;
            RectangleClassesTextBoxWidth.BackColor = Color.White;
            RectangleClassesTextBoxColor.BackColor = Color.White;
        }
    }
}