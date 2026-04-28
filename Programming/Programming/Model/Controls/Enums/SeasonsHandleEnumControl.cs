using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model.Controls.Enums
{
    /// <summary>
    /// Представляет пользовательский элемент управления для обработки выбора времени года:
    /// отображение сообщений и изменение визуального оформления в зависимости от выбранного сезона.
    /// </summary>
    public partial class SeasonsHandleEnumControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonsHandleEnumControl"/>.
        /// </summary>
        public SeasonsHandleEnumControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события нажатия кнопки подтверждения выбора сезона.
        /// Отображает сообщение, соответствующее выбранному времени года, 
        /// и изменяет фон элемента управления.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            if (ComboBoxSeason.SelectedItem == null)
            {
                MessageBox.Show("Ошибка. Выберите сезон.");
                return;
            }

            string selectedText = ComboBoxSeason.SelectedItem.ToString();
            Seasons selectedSeason = (Seasons)Enum.Parse(typeof(Seasons), selectedText);

            switch (selectedSeason)
            {
                case Seasons.Summer:
                    MessageBox.Show("Астрологи объявляют месяц Лета! Население всех жилищ возросло.");
                    this.BackColor = AppColors.ValidInput;
                    break;

                case Seasons.Winter:
                    MessageBox.Show("Идём лепить снеговика!");
                    this.BackColor = Color.LightBlue;
                    break;

                case Seasons.Autumn:
                    this.BackColor = AppColors.SeasonAutumn;
                    break;

                case Seasons.Spring:
                    this.BackColor = AppColors.SeasonSpring;
                    break;
            }
        }
    }
}