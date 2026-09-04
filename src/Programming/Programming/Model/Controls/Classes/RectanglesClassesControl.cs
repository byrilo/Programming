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
    /// <summary>
    /// Представляет пользовательский элемент управления для работы с прямоугольниками:
    /// отображение списка, редактирование параметров, поиск прямоугольника с максимальной шириной
    /// и визуализация на канве.
    /// </summary>
    public partial class RectanglesClassesControl : UserControl
    {
        /// <summary>
        /// Список всех прямоугольников, отображаемых в элементе управления.
        /// </summary>
        private List<ModelRectangle> _rectangles = new List<ModelRectangle>();

        /// <summary>
        /// Ссылка на текущий выбранный прямоугольник.
        /// </summary>
        private ModelRectangle _currentRectangle;

        /// <summary>
        /// Список панелей, визуализирующих прямоугольники на канве.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectanglesClassesControl"/>.
        /// </summary>
        public RectanglesClassesControl()
        {
            InitializeComponent();
            InitializeRectanglesData();
        }
        /// <summary>
        /// Инициализирует данные о пяти прямоугольниках со случайными параметрами 
        /// и добавляет их в список для отображения.
        /// </summary>
        private void InitializeRectanglesData()
        {
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int canvasWidth = RectangleClassesListBox.ClientSize.Width;
                int canvasHeight = RectangleClassesListBox.ClientSize.Height;

                int x = rnd.Next(15 + 75, canvasWidth - 15 - 75);
                int y = rnd.Next(15 + 75, canvasHeight - 15 - 75);

                double length = rnd.Next(50, 150);
                double width = rnd.Next(50, 150);
                string color = ((Colors)rnd.Next(0, Enum.GetValues(typeof(Colors)).Length)).ToString();

                ModelRectangle rect = new ModelRectangle(length, width, color, x, y);
                rect.Number = i + 1;

                _rectangles.Add(rect);
                RectangleClassesListBox.Items.Add(rect);
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке прямоугольников.
        /// Заполняет текстовые поля данными выбранного прямоугольника и сбрасывает цвета валидации.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleClassesListBox.SelectedIndex < 0) return;
            _currentRectangle = _rectangles[RectangleClassesListBox.SelectedIndex];

            RectangleClassesTextBoxLenght.Text = _currentRectangle.Length.ToString();
            RectangleClassesTextBoxWidth.Text = _currentRectangle.Width.ToString();
            RectangleClassesTextBoxColor.Text = _currentRectangle.Color;

            RectangleClassesTextBoxLenght.BackColor = AppColors.ValidInput;
            RectangleClassesTextBoxWidth.BackColor = AppColors.ValidInput;
            RectangleClassesTextBoxColor.BackColor = AppColors.ValidInput;
        }

        /// <summary>
        /// Обработчик события изменения текста в поле длины прямоугольника.
        /// Выполняет валидацию ввода и обновление данных текущего прямоугольника.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RectangleClassesTextBoxLenght_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            try
            {
                double length = double.Parse(RectangleClassesTextBoxLenght.Text);
                _currentRectangle.Length = length;
                RectangleClassesTextBoxLenght.BackColor = AppColors.ValidInput;
            }
            catch (Exception)
            {
                RectangleClassesTextBoxLenght.BackColor = AppColors.InvalidInput;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле ширины прямоугольника.
        /// Выполняет валидацию ввода и обновление данных текущего прямоугольника.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RectangleClassesTextBoxWidth_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            try
            {
                double width = double.Parse(RectangleClassesTextBoxWidth.Text);
                _currentRectangle.Width = width;
                RectangleClassesTextBoxWidth.BackColor = AppColors.ValidInput;
            }
            catch (Exception)
            {
                RectangleClassesTextBoxWidth.BackColor = AppColors.InvalidInput;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле цвета прямоугольника.
        /// Обновляет значение цвета текущего прямоугольника.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RectangleClassesTextBoxColor_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                _currentRectangle.Color = RectangleClassesTextBoxColor.Text;
            }
        }

        /// <summary>
        /// Находит индекс прямоугольника с максимальной шириной в списке.
        /// </summary>
        /// <param name="rectangles">Список прямоугольников для поиска.</param>
        /// <returns>Возвращает индекс прямоугольника с максимальной шириной, или -1 если список пуст.</returns>
        private int FindRectangleWithMaxWidth(List<ModelRectangle> rectangles)
        {
            if (rectangles == null || rectangles.Count == 0)
                return -1;

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

        /// <summary>
        /// Обработчик события нажатия кнопки поиска прямоугольника с максимальной шириной.
        /// Выбирает найденный прямоугольник в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RectangleClassesFindButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectangles);
            RectangleClassesListBox.SelectedIndex = index;
        }
    }
}