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
        // Объявление классов и переменных для работы с прямоугольниками
        private Programming.Model.Rectangle[] _rectangles;
        private Programming.Model.Rectangle _currentRectangle;

        private void InitializeRectanglesData() // Метод для инициализации данных о прямоугольниках
        {
            Random rnd = new Random();
            _rectangles = new Programming.Model.Rectangle[5];

            // Генерация прямоугольников с случайными данными и добавление их в массив
            for (int i = 0; i < _rectangles.Length; i++)
            {
                // Генерация случайных данных для прямоугольника
                double length = rnd.Next(1, 100);
                double width = rnd.Next(1, 100);
                string color = rnd.Next(0, 2) == 0 ? "Red" : "Blue"; // Случайный цвет 

                // Создание нового прямоугольника и сохранение его в массив
                _rectangles[i] = new Programming.Model.Rectangle(length, width, color);
                _rectangles[i].Number = i + 1; // Устанавливаем номер

                // Добавление прямоугольника в ListBox для отображения
                // ToString() должен быть переопределён в классе Rectangle для отображения понятного текста.
                RectangleClassesListBox.Items.Add(_rectangles[i]);
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e) // Обработчик события изменения выбранного элемента в ListBox прямоугольников
        {
            // Проверка на то что элемент выбран
            if (RectangleClassesListBox.SelectedIndex < 0) return;

            // Получение объекта по индексу
            _currentRectangle = _rectangles[RectangleClassesListBox.SelectedIndex];

            // Заполнение TextBox
            RectangleClassesTextBoxLenght.Text = _currentRectangle.Length.ToString();
            RectangleClassesTextBoxWidth.Text = _currentRectangle.Width.ToString();
            RectangleClassesTextBoxColor.Text = _currentRectangle.Color;

            // Сброс цвета фона TextBox на белый при выборе нового элемента
            RectangleClassesTextBoxLenght.BackColor = Color.White;
            RectangleClassesTextBoxWidth.BackColor = Color.White;
            RectangleClassesTextBoxColor.BackColor = Color.White;
        }

        private void RectangleClassesFindButton_Click(object sender, EventArgs e)
        {

        }

        private void RectangleClassesTextBoxLenght_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return; // Проверка на то, что значение выбрано
            try
            {
                // Преобразование текста в число
                double length = double.Parse(RectangleClassesTextBoxLenght.Text);
                // Присваивание через свойство
                _currentRectangle.Length = length;
                // Белый фон при успешном вводе
                RectangleClassesTextBoxLenght.BackColor = Color.White;
            }
            catch (Exception)
            {
                RectangleClassesTextBoxLenght.BackColor = Color.LightPink; // Розовый фон при ошибке
            }
        }

        private void RectangleClassesTextBoxWidth_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return; // Проверка на то, что значение выбрано
            try
            {
                // Преобразование текста в число
                double width = double.Parse(RectangleClassesTextBoxWidth.Text);

                // Присваивание через свойство
                _currentRectangle.Width = width;

                // Белый фон при успешном вводе
                RectangleClassesTextBoxWidth.BackColor = Color.White;
            }
            catch (Exception)
            {
                RectangleClassesTextBoxWidth.BackColor = Color.LightPink; // Розовый фон при ошибке
            }
        }

        private void RectangleClassesTextBoxColor_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null) // Проверка на то, что значение выбрано
            {
                _currentRectangle.Color = RectangleClassesTextBoxColor.Text;
            }
        }
    }
}