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
    public partial class SeasonsHandleEnumControl : UserControl
    {
        public SeasonsHandleEnumControl()
        {
            InitializeComponent();
        }

        private void SeasonsHandleEnumControl_Load(object sender, EventArgs e)
        {

        }
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
                    this.BackColor = AppColors.ValidInput; // Или любой другой цвет
                    break;

                case Seasons.Winter:
                    MessageBox.Show("Идём лепить снеговика!");
                    this.BackColor = Color.LightBlue; // Цвет зимы
                    break;

                case Seasons.Autumn:
                    this.BackColor = AppColors.SeasonAutumn; // Оранжевый цвет осени
                    break;

                case Seasons.Spring:
                    this.BackColor = AppColors.SeasonSpring; // Зелёный цвет весны
                    break;
            }
        }
    }
}
