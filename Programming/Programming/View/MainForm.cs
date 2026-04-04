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
using ModelRectangle = Programming.Model.Rectangle;

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
        private List<ModelRectangle> _rectangles = new List<ModelRectangle>();
        private ModelRectangle _currentRectangle;
        private List<Panel> _rectanglePanels = new List<Panel>();


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

            for (int i = 0; i < 5; i++)
            {
                // Генерация координат 
                int canvasWidth = CanvasPanel.ClientSize.Width;
                int canvasHeight = CanvasPanel.ClientSize.Height;

                int x = rnd.Next(15 + 75, canvasWidth - 15 - 75);  // +75 для учёта половины ширины
                int y = rnd.Next(15 + 75, canvasHeight - 15 - 75); // +75 для учёта половины высоты
                double length = rnd.Next(50, 150); // Случайная высота
                double width = rnd.Next(50, 150);  // Случайная ширина
                string color = ((Colors)rnd.Next(0, Enum.GetValues(typeof(Colors)).Length)).ToString();

                // Создаём прямоугольник
                ModelRectangle rect = new ModelRectangle(length, width, color, x, y);
                rect.Number = i + 1;

                // Добавляем прямоугольник в список
                _rectangles.Add(rect);

                // Создаём панель для отображения на канве
                Panel panel = new Panel
                {
                    // Location — это верхний левый угол панели,
                    // а у нас есть центр прямоугольника, поэтому вычитаем половину размера
                    Location = new Point(x - (int)width / 2, y - (int)length / 2),
                    Width = (int)width,
                    Height = (int)length,
                    BackColor = Color.FromArgb(127, 127, 255, 127), // Зелёный 
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Добавляем панель в список панелей
                _rectanglePanels.Add(panel);

                // Добавляем панель на канву
                CanvasPanel.Controls.Add(panel);

                // Добавляем в ListBox для отображения
                RectangleClassesListBox.Items.Add(rect);
                listBoxRectangles.Items.Add(rect);
            }

            // проверяем пересечения
            FindCollisions();
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
            textBoxWidth.Text = _currentRectangle.Width.ToString();
            textBoxLength.Text = _currentRectangle.Length.ToString();
            RectangleClassesTextBoxColor.Text = _currentRectangle.Color;
            // Сброс цвета фона TextBox на белый при выборе нового элемента
            RectangleClassesTextBoxLenght.BackColor = Color.White;
            RectangleClassesTextBoxWidth.BackColor = Color.White;
            RectangleClassesTextBoxColor.BackColor = Color.White;
            textBoxCenterX.Text = _currentRectangle.Center.X.ToString();
            textBoxCenterY.Text = _currentRectangle.Center.Y.ToString();
            textBoxID.Text = _currentRectangle.Id.ToString();
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

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;

            try
            {
                // Преобразование текста в число
                double length = double.Parse(textBoxLength.Text);

                // Присваивание через свойство прямоугольника
                _currentRectangle.Length = length;

                // Белый фон при успешном вводе
                textBoxLength.BackColor = Color.White;

                // Обновляем панель на канве
                int index = _rectangles.IndexOf(_currentRectangle);
                if (index >= 0)
                {                   
                    _rectanglePanels[index].Height = (int)length;

                    // Пересчитываем позицию Y для центрирования
                    int newY = _currentRectangle.Center.Y - (int)length / 2;
                    int currentX = _rectanglePanels[index].Location.X;
                    _rectanglePanels[index].Location = new Point(currentX, newY);
                }

                UpdateRectanglesListBox();
                FindCollisions();
            }
            catch (ArgumentException ex)
            {
                textBoxLength.BackColor = Color.LightPink;
            }
            catch (FormatException)
            {
                textBoxLength.BackColor = Color.LightPink;
            }
        }

        private void listBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex < 0)
            {
                ClearRectangleInfo();
                return;
            }
            
            
            _currentRectangle = _rectangles[listBoxRectangles.SelectedIndex]; // Получение объекта по индексу
            UpdateRectangleInfo(_currentRectangle);  // Заполнение TextBox

            textBoxWidth.Text = _currentRectangle.Width.ToString();
            textBoxLength.Text = _currentRectangle.Length.ToString();
            RectangleClassesTextBoxColor.Text = _currentRectangle.Color;
            // Сброс цвета фона TextBox на белый при выборе нового элемента
            RectangleClassesTextBoxLenght.BackColor = Color.White;
            RectangleClassesTextBoxWidth.BackColor = Color.White;
            RectangleClassesTextBoxColor.BackColor = Color.White;
            textBoxCenterX.Text = _currentRectangle.Center.X.ToString();
            textBoxCenterY.Text = _currentRectangle.Center.Y.ToString();
            textBoxID.Text = _currentRectangle.Id.ToString();
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return; // Проверка на то, что значение выбрано
            try
            {
                // Преобразование текста в число
                double width = double.Parse(textBoxWidth.Text);
                // Присваивание через свойство
                _currentRectangle.Width = width;
                // Белый фон при успешном вводе
                textBoxWidth.BackColor = Color.White;
                // Обновляем панель на канве
                int index = _rectangles.IndexOf(_currentRectangle);
                if (index >= 0)
                {
                    _rectanglePanels[index].Width = (int)width;
                    // Пересчитываем позицию для центрирования
                    int newX = _currentRectangle.Center.X - (int)width / 2;
                    _rectanglePanels[index].Location = new Point(newX, _rectanglePanels[index].Location.Y);
                }
                UpdateRectanglesListBox();
                FindCollisions();
            }
            catch (Exception)
            {
                textBoxWidth.BackColor = Color.LightPink; // Розовый фон при ошибке
            }
        }
        private void UpdateRectanglesListBox()
        {
            listBoxRectangles.Items.Clear();
            foreach (var rect in _rectangles)
            {
                listBoxRectangles.Items.Add(
                    $"Rectangle {rect.Id}"
                );
            }
        }
        /// <summary>
        /// Очистка всех текстовых полей
        /// </summary>
        private void ClearRectangleInfo()
        {
            textBoxID.Text = "";
            textBoxCenterX.Text = "";
            textBoxCenterY.Text = "";
            textBoxWidth.Text = "";
            textBoxLength.Text = "";
            RectangleClassesTextBoxColor.Text = "";
        }
        /// <summary>
        /// Обновление данных в текстовых полях по указанному прямоугольнику
        /// </summary>
        private void UpdateRectangleInfo(ModelRectangle rectangle)
        {
            // если rectangle null, очищаем поля
            if (rectangle == null)
            {
                ClearRectangleInfo();
                return;
            }

            textBoxID.Text = rectangle.Id.ToString();
            textBoxCenterX.Text = rectangle.Center.X.ToString();
            textBoxCenterY.Text = rectangle.Center.Y.ToString();
            textBoxWidth.Text = rectangle.Width.ToString();
            textBoxLength.Text = rectangle.Length.ToString();
            RectangleClassesTextBoxColor.Text = rectangle.Color;
        }
        private void FindCollisions()
        {
            // Если списки пусты выход
            if (_rectangles.Count == 0)
                return;

            // Сначала все панели делаем зелёными
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            }

            // Проверяем все пары прямоугольников
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (i == j)
                        continue;

                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        // Красим оба пересекающихся прямоугольника в красный
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        private void buttonRectanglesAdd_Click(object sender, EventArgs e)
        {
            // Получаем размеры канвы
            int canvasWidth = CanvasPanel.ClientSize.Width;
            int canvasHeight = CanvasPanel.ClientSize.Height;

            // Создаём случайный прямоугольник
            Random rnd = new Random();
            int x = rnd.Next(15, canvasWidth - 15);
            int y = rnd.Next(15, canvasHeight - 15);
            double length = rnd.Next(50, 150);
            double width = rnd.Next(50, 150);
            string color = ((Colors)rnd.Next(0, Enum.GetValues(typeof(Colors)).Length)).ToString();

            ModelRectangle rect = new ModelRectangle(length, width, color, x, y);
            rect.Number = _rectangles.Count + 1;

            // Добавляем в список прямоугольников
            _rectangles.Add(rect);

            // Создаём панель
            Panel panel = new Panel
            {
                Location = new Point(x - (int)width / 2, y - (int)length / 2),
                Width = (int)width,
                Height = (int)length,
                BackColor = Color.FromArgb(127, 127, 255, 127),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Добавляем панель  на канву и в список
            _rectanglePanels.Add(panel);
            CanvasPanel.Controls.Add(panel);

            // Обновляем ListBox
            UpdateRectanglesListBox();

            // Проверяем пересечения
            FindCollisions();
        }

        private void buttonRectanglesDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex == -1)
                return;

            int selectedIndex = listBoxRectangles.SelectedIndex;

            // Удаляем панель с канвы
            CanvasPanel.Controls.Remove(_rectanglePanels[selectedIndex]);

            // Удаляем из списков
            _rectanglePanels.RemoveAt(selectedIndex);
            _rectangles.RemoveAt(selectedIndex);

            // Обновляем ListBox
            UpdateRectanglesListBox();

            // Очищаем поля
            ClearRectangleInfo();

            // Проверяем пересечения
            FindCollisions();
        }
    }
}
