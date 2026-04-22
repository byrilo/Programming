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
    public partial class RectanglesClassesControl : UserControl
    {

        public RectanglesClassesControl()
        {
            InitializeComponent();
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
        private List<ModelRectangle> _rectangles = new List<ModelRectangle>();
        private ModelRectangle _currentRectangle;
        private List<Panel> _rectanglePanels = new List<Panel>();
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
        
    }
}
