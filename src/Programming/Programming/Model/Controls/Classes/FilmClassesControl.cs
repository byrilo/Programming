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
    /// Представляет пользовательский элемент управления для работы с фильмами: 
    /// отображение списка, редактирование параметров и поиск фильма с максимальным рейтингом.
    /// </summary>
    public partial class FilmClassesControl : UserControl
    {
        /// <summary>
        /// Массив для хранения данных о пяти фильмах.
        /// </summary>
        private Film[] _films;

        /// <summary>
        /// Ссылка на текущий выбранный фильм.
        /// </summary>
        private Film _currentFilm;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="FilmClassesControl"/>.
        /// </summary>
        public FilmClassesControl()
        {
            InitializeComponent();
            InitializeFilmsData();
        }

        /// <summary>
        /// Обработчик события загрузки элемента управления.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FilmClassesControl_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Инициализирует данные о пяти фильмах со случайными параметрами 
        /// и добавляет их в список для отображения.
        /// </summary>
        private void InitializeFilmsData()
        {
            Random rnd = new Random();
            _films = new Film[5];

            for (int i = 0; i < _films.Length; i++)
            {
                string name = $"Film {i + 1}";
                int minutesDuration = rnd.Next(60, 220);
                int yearOfCreation = rnd.Next(1990, 2026);

                string genre = ((Genre)(new Random().Next(0, Enum.GetValues(typeof(Genre)).Length))).ToString();

                double rating = Math.Round(rnd.NextDouble() * 10, 1);

                _films[i] = new Programming.Model.Film(name, minutesDuration, yearOfCreation, genre, rating);
                _films[i].Number = i + 1;
                FilmClassesListBox.Items.Add(_films[i]);
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке фильмов.
        /// Заполняет текстовые поля данными выбранного фильма и сбрасывает цвета валидации.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FilmClassesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilmClassesListBox.SelectedIndex < 0) return;
            _currentFilm = _films[FilmClassesListBox.SelectedIndex];

            FilmClassesTextBoxDuration.Text = _currentFilm.MinutesDuration.ToString();
            FilmClassesTextBoxYear.Text = _currentFilm.YearOfCreation.ToString();
            FilmClassesTextBoxGenre.Text = _currentFilm.Genre.ToString();
            FilmClassesTextBoxRating.Text = _currentFilm.Rating.ToString();

            FilmClassesTextBoxDuration.BackColor = AppColors.ValidInput;
            FilmClassesTextBoxYear.BackColor = AppColors.ValidInput;
            FilmClassesTextBoxGenre.BackColor = AppColors.ValidInput;
            FilmClassesTextBoxRating.BackColor = AppColors.ValidInput;
        }

        /// <summary>
        /// Находит индекс фильма с максимальным рейтингом в массиве.
        /// </summary>
        /// <param name="films">Массив фильмов для поиска.</param>
        /// <returns>Возвращает индекс фильма с максимальным рейтингом.</returns>
        private int FindFilmWithMaxRating(Film[] films)
        {
            int maxIndex = 0;
            double maxRating = films[0].Rating;

            for (int i = 1; i < films.Length; i++)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = films[i].Rating;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки поиска фильма с максимальным рейтингом.
        /// Выбирает найденный фильм в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FilmClassesFindButton_Click(object sender, EventArgs e)
        {
            int index = FindFilmWithMaxRating(_films);
            FilmClassesListBox.SelectedIndex = index;
        }

        /// <summary>
        /// Обработчик события изменения текста в поле длительности фильма.
        /// Выполняет валидацию ввода и обновление данных текущего фильма.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FilmClassesTextBoxDuration_TextChanged(object sender, EventArgs e)
        {
            if (_currentFilm == null) return;
            try
            {
                int minutesDuration = int.Parse(FilmClassesTextBoxDuration.Text);
                _currentFilm.MinutesDuration = minutesDuration;
                FilmClassesTextBoxDuration.BackColor = AppColors.ValidInput;
            }
            catch (Exception)
            {
                FilmClassesTextBoxDuration.BackColor = AppColors.InvalidInput;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле года создания фильма.
        /// Выполняет валидацию ввода и обновление данных текущего фильма.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FilmClassesTextBoxYear_TextChanged(object sender, EventArgs e)
        {
            if (_currentFilm == null) return;
            try
            {
                int yearOfCreation = int.Parse(FilmClassesTextBoxYear.Text);
                _currentFilm.YearOfCreation = yearOfCreation;
                FilmClassesTextBoxYear.BackColor = AppColors.ValidInput;
            }
            catch (Exception)
            {
                FilmClassesTextBoxYear.BackColor = AppColors.InvalidInput;
            }
        }
        /// <summary>
        /// Обработчик события изменения текста в поле рейтинга фильма.
        /// Выполняет валидацию ввода и обновление данных текущего фильма.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FilmClassesTextBoxRating_TextChanged(object sender, EventArgs e)
        {
            if (_currentFilm == null) return;
            try
            {
                double rating = double.Parse(FilmClassesTextBoxRating.Text);
                _currentFilm.Rating = rating;
                FilmClassesTextBoxRating.BackColor = AppColors.ValidInput;
            }
            catch (Exception)
            {
                FilmClassesTextBoxRating.BackColor = AppColors.InvalidInput;
            }
        }
    }
}