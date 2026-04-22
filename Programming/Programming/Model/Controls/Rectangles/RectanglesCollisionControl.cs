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

    public partial class RectanglesCollisionControl : UserControl
    {
        // Поля для хранения данных о прямоугольниках
        private List<ModelRectangle> _rectangles = new List<ModelRectangle>();
        private ModelRectangle _currentRectangle;
        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();
            InitializeRectanglesData();
        }

        /// <summary>
        /// Инициализирует 5 прямоугольников в программу
        /// </summary>
        private void InitializeRectanglesData()
        {
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                // Генерация координат с учётом размеров CanvasPanel
                int canvasWidth = CanvasPanel.ClientSize.Width;
                int canvasHeight = CanvasPanel.ClientSize.Height;

                int x = rnd.Next(15 + 75, canvasWidth - 15 - 75);
                int y = rnd.Next(15 + 75, canvasHeight - 15 - 75);
                double length = rnd.Next(50, 150);
                double width = rnd.Next(50, 150);
                string color = ((Colors)rnd.Next(0, Enum.GetValues(typeof(Colors)).Length)).ToString();

                // Создаём прямоугольник
                ModelRectangle rect = new ModelRectangle(length, width, color, x, y);
                rect.Number = i + 1;

                // Добавляем в список
                _rectangles.Add(rect);

                // Создаём панель для отображения на канве
                Panel panel = new Panel
                {
                    Location = new Point(x - (int)width / 2, y - (int)length / 2),
                    Width = (int)width,
                    Height = (int)length,
                    BackColor = Color.FromArgb(127, 127, 255, 127),
                    BorderStyle = BorderStyle.FixedSingle
                };

                _rectanglePanels.Add(panel);
                CanvasPanel.Controls.Add(panel);

                // Добавляем в ListBox
                listBoxRectangles.Items.Add(rect);
            }

            FindCollisions();
        }
        /// <summary>
        /// Обработчик выбора прямоугольника в listBoxRectangles
        /// </summary>
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
        /// Валидация и обновление длины с перерисовкой канвы
        /// </summary>
        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;

            try
            {
                double length = double.Parse(textBoxLength.Text);
                _currentRectangle.Length = length;
                textBoxLength.BackColor = AppColors.ValidInput;

                // Обновляем панель на канве
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
        /// Валидация и обновление ширины с перерисовкой канвы
        /// </summary>
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
        /// Проверка пересечений прямоугольников и подсветка
        /// </summary>
        private void FindCollisions()
        {
            if (_rectangles.Count == 0)
                return;

            // Сброс цвета всех панелей
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = AppColors.RectangleNormal;
            }

            // Проверка всех пар
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
        /// Добавление нового прямоугольника
        /// </summary>
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
        /// Удаление выбранного прямоугольника
        /// </summary>
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
        /// Обновление списка listBoxRectangles
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
        /// Очистка всех текстовых полей
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
        /// Заполнение полей данными прямоугольника
        /// </summary>
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

        /// <summary>
        /// Обработчик Paint для CanvasPanel (если нужен)
        /// </summary>
        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {
            // Можно добавить дополнительную отрисовку, если потребуется
        }

        /// <summary>
        /// Пустой обработчик для textBoxCenterX (заглушка)
        /// </summary>
        private void textBoxCenterX_TextChanged(object sender, EventArgs e)
        {
            // Если потребуется логика изменения координаты X
        }

        private void RectanglesCollisionControl_Load(object sender, EventArgs e)
        {

        }
    }
}