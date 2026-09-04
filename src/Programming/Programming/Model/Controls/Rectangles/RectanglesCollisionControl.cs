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
    /// отображение списка, редактирование параметров, добавление, удаление и визуализация
    /// пересечений на канве.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
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
        /// Создаёт экземпляр класса <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
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
                int canvasWidth = CanvasPanel.ClientSize.Width;
                int canvasHeight = CanvasPanel.ClientSize.Height;

                int x = rnd.Next(15 + 75, canvasWidth - 15 - 75);
                int y = rnd.Next(15 + 75, canvasHeight - 15 - 75);
                double length = rnd.Next(50, 150);
                double width = rnd.Next(50, 150);
                string color = ((Colors)rnd.Next(0, Enum.GetValues(typeof(Colors)).Length)).ToString();

                ModelRectangle rect = new ModelRectangle(length, width, color, x, y);
                rect.Number = i + 1;

                _rectangles.Add(rect);

                Panel panel = new Panel
                {
                    Location = new Point(x - (int)width / 2, y - (int)length / 2),
                    Width = (int)width,
                    Height = (int)length,
                    BackColor = AppColors.RectangleNormal,
                    BorderStyle = BorderStyle.FixedSingle
                };

                _rectanglePanels.Add(panel);
                CanvasPanel.Controls.Add(panel);
                listBoxRectangles.Items.Add(rect);
            }

            FindCollisions();
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке прямоугольников.
        /// Заполняет текстовые поля данными выбранного прямоугольника.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void listBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex < 0)
            {
                ClearRectangleInfo();
                return;
            }

            _currentRectangle = _rectangles[listBoxRectangles.SelectedIndex];
            UpdateRectangleInfo(_currentRectangle);

            textBoxWidth.Text = _currentRectangle.Width.ToString();
            textBoxLength.Text = _currentRectangle.Length.ToString();
            textBoxCenterX.Text = _currentRectangle.Center.X.ToString();
            textBoxCenterY.Text = _currentRectangle.Center.Y.ToString();
            textBoxID.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// Обработчик события изменения текста в поле длины прямоугольника.
        /// Выполняет валидацию ввода, обновление данных и перерисовку канвы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;

            try
            {
                double length = double.Parse(textBoxLength.Text);
                _currentRectangle.Length = length;
                textBoxLength.BackColor = AppColors.ValidInput;

                int index = _rectangles.IndexOf(_currentRectangle);
                if (index >= 0)
                {
                    _rectanglePanels[index].Height = (int)length;
                    int newY = _currentRectangle.Center.Y - (int)length / 2;
                    int currentX = _rectanglePanels[index].Location.X;
                    _rectanglePanels[index].Location = new Point(currentX, newY);
                }

                UpdateRectanglesListBox();
                FindCollisions();
            }
            catch (ArgumentException)
            {
                textBoxLength.BackColor = AppColors.InvalidInput;
            }
            catch (FormatException)
            {
                textBoxLength.BackColor = AppColors.InvalidInput;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле ширины прямоугольника.
        /// Выполняет валидацию ввода, обновление данных и перерисовку канвы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            try
            {
                double width = double.Parse(textBoxWidth.Text);
                _currentRectangle.Width = width;
                textBoxWidth.BackColor = AppColors.ValidInput;

                int index = _rectangles.IndexOf(_currentRectangle);
                if (index >= 0)
                {
                    _rectanglePanels[index].Width = (int)width;
                    int newX = _currentRectangle.Center.X - (int)width / 2;
                    _rectanglePanels[index].Location = new Point(newX, _rectanglePanels[index].Location.Y);
                }
                UpdateRectanglesListBox();
                FindCollisions();
            }
            catch (Exception)
            {
                textBoxWidth.BackColor = AppColors.InvalidInput;
            }
        }

        /// <summary>
        /// Проверяет пересечения всех прямоугольников и подсвечивает столкнувшиеся.
        /// </summary>
        private void FindCollisions()
        {
            if (_rectangles.Count == 0)
                return;

            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = AppColors.RectangleNormal;
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (i == j) continue;

                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.RectangleCollision;
                        _rectanglePanels[j].BackColor = AppColors.RectangleCollision;
                    }
                }
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки добавления нового прямоугольника.
        /// Генерирует прямоугольник со случайными параметрами и добавляет его на канву.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void buttonRectanglesAdd_Click(object sender, EventArgs e)
        {
            int canvasWidth = CanvasPanel.ClientSize.Width;
            int canvasHeight = CanvasPanel.ClientSize.Height;

            Random rnd = new Random();
            int x = rnd.Next(15, canvasWidth - 15);
            int y = rnd.Next(15, canvasHeight - 15);
            double length = rnd.Next(50, 150);
            double width = rnd.Next(50, 150);
            string color = ((Colors)rnd.Next(0, Enum.GetValues(typeof(Colors)).Length)).ToString();

            ModelRectangle rect = new ModelRectangle(length, width, color, x, y);
            rect.Number = _rectangles.Count + 1;

            _rectangles.Add(rect);

            Panel panel = new Panel
            {
                Location = new Point(x - (int)width / 2, y - (int)length / 2),
                Width = (int)width,
                Height = (int)length,
                BackColor = AppColors.RectangleNormal,
                BorderStyle = BorderStyle.FixedSingle
            };

            _rectanglePanels.Add(panel);
            CanvasPanel.Controls.Add(panel);

            UpdateRectanglesListBox();
            FindCollisions();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки удаления выбранного прямоугольника.
        /// Удаляет прямоугольник из списка, с канвы и из списка отображения.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void buttonRectanglesDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex == -1)
                return;

            int selectedIndex = listBoxRectangles.SelectedIndex;
            Panel panelToRemove = _rectanglePanels[selectedIndex];

            CanvasPanel.Controls.Remove(panelToRemove);
            _rectanglePanels.RemoveAt(selectedIndex);
            _rectangles.RemoveAt(selectedIndex);
            listBoxRectangles.Items.RemoveAt(selectedIndex);

            ClearRectangleInfo();
            FindCollisions();
        }

        /// <summary>
        /// Обновляет содержимое списка listBoxRectangles текущими данными о прямоугольниках.
        /// </summary>
        private void UpdateRectanglesListBox()
        {
            listBoxRectangles.Items.Clear();
            foreach (var rect in _rectangles)
            {
                listBoxRectangles.Items.Add($"Rectangle {rect.Id}");
            }
        }

        /// <summary>
        /// Очищает все текстовые поля, отображающие данные о прямоугольнике.
        /// </summary>
        private void ClearRectangleInfo()
        {
            textBoxID.Text = "";
            textBoxCenterX.Text = "";
            textBoxCenterY.Text = "";
            textBoxWidth.Text = "";
            textBoxLength.Text = "";
        }

        /// <summary>
        /// Заполняет текстовые поля данными указанного прямоугольника.
        /// </summary>
        /// <param name="rectangle">Прямоугольник, данные которого необходимо отобразить.</param>
        private void UpdateRectangleInfo(ModelRectangle rectangle)
        {
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
        }
    }
}