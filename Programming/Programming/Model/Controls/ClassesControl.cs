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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ModelRectangle = Programming.Model.Rectangle;

namespace Programming.Model.Controls
{
    public partial class ClassesControl : UserControl
    {

        public ClassesControl()
        {
            InitializeComponent();
            InitializeFilmsData();
            InitializeRectanglesData();
        }

        private void ClassesControl_Load(object sender, EventArgs e)
        {

        }
        private void InitializeRectanglesData()
        {
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                // Генерация координат
                int canvasWidth = RectangleClassesListBox.ClientSize.Width; // или CanvasPanel, если есть
                int canvasHeight = RectangleClassesListBox.ClientSize.Height;

                int x = rnd.Next(15 + 75, canvasWidth - 15 - 75);
                int y = rnd.Next(15 + 75, canvasHeight - 15 - 75);

                double length = rnd.Next(50, 150);
                double width = rnd.Next(50, 150);
                string color = ((Colors)rnd.Next(0, Enum.GetValues(typeof(Colors)).Length)).ToString();

                // Создаём прямоугольник с ВСЕМИ параметрами
                ModelRectangle rect = new ModelRectangle(length, width, color, x, y);
                rect.Number = i + 1;

                _rectangles.Add(rect);
                RectangleClassesListBox.Items.Add(rect);
            }
        }
        private Programming.Model.Film[] _films;
        private Programming.Model.Film _currentFilm;
        private List<ModelRectangle> _rectangles = new List<ModelRectangle>();
        private ModelRectangle _currentRectangle;
        private List<Panel> _rectanglePanels = new List<Panel>();

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
        private int FindRectangleWithMaxWidth(List<ModelRectangle> rectangles)
        {
            if (rectangles == null || rectangles.Count == 0)
                return -1; // Защита от пустого списка

            int maxIndex = 0;
            double maxWidth = rectangles[0].Width;


            for (int i = 1; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxIndex = i;
                }
            }
            return maxIndex;
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
            try
            {
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
