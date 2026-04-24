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
    public partial class FilmClassesControl : UserControl
    {
        public FilmClassesControl()
        {
            InitializeComponent();
            InitializeFilmsData();
        }

        private void FilmClassesControl_Load(object sender, EventArgs e)
        {

        }
        private Film[] _films;
        private Film _currentFilm;
        /// <summary>
        /// Функция иницилизирующая 5 фильмов в программу
        /// </summary>
        private void InitializeFilmsData()
        {
            Random rnd = new Random();
            _films = new Film[5];

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
            FilmClassesTextBoxDuration.BackColor = AppColors.ValidInput;
            FilmClassesTextBoxYear.BackColor = AppColors.ValidInput;
            FilmClassesTextBoxGenre.BackColor = AppColors.ValidInput;
            FilmClassesTextBoxRating.BackColor = AppColors.ValidInput;
        }
        private int FindFilmWithMaxRating(Film[] films)
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
                FilmClassesTextBoxDuration.BackColor = AppColors.ValidInput;
            }
            catch (Exception)
            {
                FilmClassesTextBoxDuration.BackColor = AppColors.InvalidInput; // Розовый фон при ошибке
            }
        }

        private void FilmClassesTextBoxYear_TextChanged(object sender, EventArgs e)
        {
            if (_currentFilm == null) return; // Проверка на то, что значение выбрано
            try
            {
                int yearOfCreation = int.Parse(FilmClassesTextBoxYear.Text);
                _currentFilm.YearOfCreation = yearOfCreation;
                FilmClassesTextBoxYear.BackColor = AppColors.ValidInput;
            }
            catch (Exception)
            {
                FilmClassesTextBoxYear.BackColor = AppColors.InvalidInput; // Розовый фон при ошибке
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
                FilmClassesTextBoxRating.BackColor = AppColors.ValidInput;
            }
            catch (Exception)
            {
                FilmClassesTextBoxRating.BackColor = AppColors.InvalidInput; // Розовый фон при ошибке
            }
        }

        private void FilmClassesGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
