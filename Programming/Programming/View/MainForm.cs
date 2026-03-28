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
            InitializeRectanglesData(); // Прямоугольники
            InitializeFilmsData(); // Фильмы
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
        private Programming.Model.Rectangle[] _rectangles; // Массив для хранения прямугольников
        private Programming.Model.Rectangle _currentRectangle; // Переменная для хранения текущего выбранного прямоугольника

        private Programming.Model.Film[] _films; // Массив для хранения фильмов
        private Programming.Model.Film _currentFilm; // Переменная для хранения текущего выбранного фильма
        /// <summary>
        /// Функция иницилизирующая 5 фильмов в программу
        /// </summary>
        private void InitializeFilmsData()
        {
            Random rnd = new Random();  
            _films = new Programming.Model.Film[5];

            for (int i = 0; i < _films.Length; i++)
            {
                string name = $"Film {i + 1}";
                int minutesDuration = rnd.Next(60, 220); // Случайные значения длительности фильма
                int yearOfCreation = rnd.Next(1990, 2026); // Случайные значения года создания фильма

                string genre = ((Genre)(new Random().Next(0, Enum.GetValues(typeof(Genre)).Length))).ToString(); // Берём жанры из класса жанров

                //string[] genres = { "Action", "Comedy", "Drama", "Horror", "Sci-Fi" };
                //string genre = genres[rnd.Next(0, genres.Length)];

                // Используем тот же rnd для рейтинга
                double rating = Math.Round(rnd.NextDouble() * 10, 1);

                _films[i] = new Programming.Model.Film(name, minutesDuration, yearOfCreation, genre, rating);
                _films[i].Number = i + 1; // Устанавливаем номер
                FilmClassesListBox.Items.Add(_films[i]);
            }
        }
        // string genre = ((Genre)(new Random().Next(0, Enum.GetValues(typeof(Genre)).Length))).ToString();
        /// <summary>
        /// Функция, которая срабатывает при выборе фильма, инициализируя данные в текстбоксы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilmClassesListBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (FilmClassesListBox.SelectedIndex < 0) return; // Проверка на то, что элемент выбран
            _currentFilm = _films[FilmClassesListBox.SelectedIndex]; // Получение фильма по индексу
            // Заполнение TextBox
            FilmClassesTextBoxDuration.Text = _currentFilm.MinutesDuration.ToString();
            FilmClassesTextBoxYear.Text = _currentFilm.YearOfCreation.ToString();
            FilmClassesTextBoxGenre.Text = _currentFilm.Genre.ToString();
            FilmClassesTextBoxRating.Text = _currentFilm.Rating.ToString();
            // Сброс цвета фона TextBox на белый при выборе нового элемента
            FilmClassesTextBoxDuration.BackColor = Color.White;
            FilmClassesTextBoxYear.BackColor = Color.White;
            FilmClassesTextBoxGenre.BackColor = Color.White;
            FilmClassesTextBoxRating.BackColor = Color.White;
        }
        /// <summary>
        /// Функция инициализирует 5 прямоугольников в программу (Листбокс)
        /// </summary>
        private void InitializeRectanglesData() 
        {
            Random rnd = new Random();
            _rectangles = new Programming.Model.Rectangle[5];

            for (int i = 0; i < _rectangles.Length; i++)
            {
                double length = rnd.Next(1, 100); // Случайная длина
                double width = rnd.Next(1, 100); // Случайная ширина
                string color = ((Colors)(rnd.Next(0, Enum.GetValues(typeof(Colors)).Length))).ToString(); // Случайный цвет 
                _rectangles[i] = new Programming.Model.Rectangle(length, width, color);
                _rectangles[i].Number = i + 1; // Устанавливаем номер
                RectangleClassesListBox.Items.Add(_rectangles[i]);
            }
        }
        /// <summary>
        /// Функция, которая срабатывает при выборе прямоугольника, инициализируя данные в текстбоксы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e) // Обработчик события изменения выбранного элемента в ListBox прямоугольников
        {
            if (RectangleClassesListBox.SelectedIndex < 0) return; // Проверка на то что элемент выбран
            _currentRectangle = _rectangles[RectangleClassesListBox.SelectedIndex]; // Получение объекта по индексу
            // Заполнение TextBox
            RectangleClassesTextBoxLenght.Text = _currentRectangle.Length.ToString();
            RectangleClassesTextBoxWidth.Text = _currentRectangle.Width.ToString();
            RectangleClassesTextBoxColor.Text = _currentRectangle.Color;
            // Сброс цвета фона TextBox на белый при выборе нового элемента
            RectangleClassesTextBoxLenght.BackColor = Color.White;
            RectangleClassesTextBoxWidth.BackColor = Color.White;
            RectangleClassesTextBoxColor.BackColor = Color.White;
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
        private int FindRectangleWithMaxWidth(Programming.Model.Rectangle[] rectangles)
        {
            int maxIndex = 0; // Индекс прямоугольника с максимальной шириной
            double maxWidth = rectangles[0].Width; // Максимальная ширина, изначально - ширина первого прямоугольника
            for (int i = 1; i < rectangles.Length; i++) // Проход по всем прямоугольникам
            {
                if (rectangles[i].Width > maxWidth) // Если текущая ширина больше максимальной
                {
                    maxWidth = rectangles[i].Width; // Обновляем максимальную ширину
                    maxIndex = i; // Обновляем индекс
                }
            }
            return maxIndex; // Возвращаем индекс прямоугольника с максимальной шириной
        }
        private void RectangleClassesFindButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectangles);
            RectangleClassesListBox.SelectedIndex = index;
        }
        private int FindFilmWithMaxRating(Programming.Model.Film[] films)
        {
            int maxIndex = 0;              // Индекс фильма с максимальным рейтингом
            double maxRating = films[0].Rating;  // Максимальный рейтинг

            for (int i = 1; i < films.Length; i++)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = films[i].Rating;  // Обновляем максимальный рейтинг
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        private void FilmClassesFindButton_Click(object sender, EventArgs e)
        {
            int index = FindFilmWithMaxRating(_films);
            FilmClassesListBox.SelectedIndex = index;
        }

        private void FilmClassesTextBoxDuration_TextChanged(object sender, EventArgs e)
        {
            if (_currentFilm == null) return; // Проверка на то, что значение выбрано
            try
            {
                // Преобразование текста в число
                int minutesDuration = int.Parse(FilmClassesTextBoxDuration.Text);
                // Присваивание через свойство
                _currentFilm.MinutesDuration = minutesDuration;
                // Белый фон при успешном вводе
                FilmClassesTextBoxDuration.BackColor = Color.White;
            }
            catch (Exception)
            {
                FilmClassesTextBoxDuration.BackColor = Color.LightPink; // Розовый фон при ошибке
            }
        }

        private void FilmClassesTextBoxYear_TextChanged(object sender, EventArgs e)
        {
            if (_currentFilm == null) return; // Проверка на то, что значение выбрано
            try
            {
                int yearOfCreation = int.Parse(FilmClassesTextBoxYear.Text);
                _currentFilm.YearOfCreation = yearOfCreation;
                FilmClassesTextBoxYear.BackColor = Color.White;
            }
            catch (Exception)
            {
                FilmClassesTextBoxYear.BackColor = Color.LightPink; // Розовый фон при ошибке
            }
        }

        private void FilmClassesTextBoxGenre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FilmClassesTextBoxRating_TextChanged(object sender, EventArgs e)
        {
            if (_currentFilm == null) return; // Проверка на то, что значение выбрано
            try             {
                double rating = double.Parse(FilmClassesTextBoxRating.Text);
                _currentFilm.Rating = rating;
                FilmClassesTextBoxRating.BackColor = Color.White;
            }
            catch (Exception)
            {
                FilmClassesTextBoxRating.BackColor = Color.LightPink; // Розовый фон при ошибке
            }
        }
    }
}