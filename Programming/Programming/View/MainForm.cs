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

namespace Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TabControl TabControlMain;
        private TabPage tabPage1;
        private Label SeasonLabel;
        private Label ResultLabel;
        private Label ParsingValueLabel;
        private Label ValuesListBoxLabel;
        private Label EnumsListBoxLabel;
        private TextBox IntValueTextBox;
        private GroupBox GroupBoxWeekParse;
        private Button ParseButton;
        private TextBox TextBoxValueParsing;
        private GroupBox GroupBoxSeason;
        private Button GoButton;
        private GroupBox GroupBoxListBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label IntValueLabel;
        private TabPage tabPageClasses;
        private GroupBox RectangleClassesGroupBox;
        private Label RectangleClassesLabelColor;
        private Label RectangleClassesLabelWidth;
        private Label RectangleClassesLabelLenght;
        private TextBox RectangleClassesTextBoxWidth;
        private TextBox RectangleClassesTextBoxColor;
        private TextBox RectangleClassesTextBoxLenght;
        private Button RectangleClassesFindButton;
        private ListBox RectangleClassesListBox;
        private GroupBox FilmClassesGroupBox;
        private Label FilmClassesLabelYear;
        private Label FilmClassesLabelDuration;
        private Label FilmClassesLabelName;
        private TextBox FilmClassesTextBoxDuration;
        private TextBox FilmClassesTextBoxYear;
        private TextBox FilmClassesTextBoxName;
        private Button FilmClassesFindButton;
        private ListBox FilmClassesListBox;
        private Label FilmClassesLabelRating;
        private Label FilmClassesLabelGenre;
        private TextBox FilmClassesTextBoxRating;
        private TextBox FilmClassesTextBoxGenre;
        private ComboBox ComboBoxSeason;

        private void InitializeComponent()
        {
            TabControlMain = new TabControl();
            tabPage1 = new TabPage();
            IntValueLabel = new Label();
            IntValueTextBox = new TextBox();
            GroupBoxWeekParse = new GroupBox();
            ParseButton = new Button();
            ResultLabel = new Label();
            TextBoxValueParsing = new TextBox();
            ParsingValueLabel = new Label();
            GroupBoxSeason = new GroupBox();
            ComboBoxSeason = new ComboBox();
            SeasonLabel = new Label();
            GoButton = new Button();
            GroupBoxListBox = new GroupBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            EnumsListBoxLabel = new Label();
            ValuesListBoxLabel = new Label();
            tabPageClasses = new TabPage();
            RectangleClassesGroupBox = new GroupBox();
            RectangleClassesLabelColor = new Label();
            RectangleClassesLabelWidth = new Label();
            RectangleClassesLabelLenght = new Label();
            RectangleClassesTextBoxWidth = new TextBox();
            RectangleClassesTextBoxColor = new TextBox();
            RectangleClassesTextBoxLenght = new TextBox();
            RectangleClassesFindButton = new Button();
            RectangleClassesListBox = new ListBox();
            FilmClassesGroupBox = new GroupBox();
            FilmClassesLabelYear = new Label();
            FilmClassesLabelDuration = new Label();
            FilmClassesLabelName = new Label();
            FilmClassesTextBoxDuration = new TextBox();
            FilmClassesTextBoxYear = new TextBox();
            FilmClassesTextBoxName = new TextBox();
            FilmClassesFindButton = new Button();
            FilmClassesListBox = new ListBox();
            FilmClassesTextBoxGenre = new TextBox();
            FilmClassesTextBoxRating = new TextBox();
            FilmClassesLabelGenre = new Label();
            FilmClassesLabelRating = new Label();
            TabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            GroupBoxWeekParse.SuspendLayout();
            GroupBoxSeason.SuspendLayout();
            GroupBoxListBox.SuspendLayout();
            tabPageClasses.SuspendLayout();
            RectangleClassesGroupBox.SuspendLayout();
            FilmClassesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlMain
            // 
            TabControlMain.Controls.Add(tabPage1);
            TabControlMain.Controls.Add(tabPageClasses);
            TabControlMain.Dock = DockStyle.Fill;
            TabControlMain.Location = new Point(0, 0);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(852, 530);
            TabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(IntValueLabel);
            tabPage1.Controls.Add(IntValueTextBox);
            tabPage1.Controls.Add(GroupBoxWeekParse);
            tabPage1.Controls.Add(GroupBoxSeason);
            tabPage1.Controls.Add(GroupBoxListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(844, 497);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(400, 41);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(68, 20);
            IntValueLabel.TabIndex = 5;
            IntValueLabel.Text = "Int value:";
            // 
            // IntValueTextBox
            // 
            IntValueTextBox.Location = new Point(400, 64);
            IntValueTextBox.Name = "IntValueTextBox";
            IntValueTextBox.ReadOnly = true;
            IntValueTextBox.Size = new Size(264, 27);
            IntValueTextBox.TabIndex = 4;
            IntValueTextBox.TextChanged += IntValueTextBox_TextChanged;
            // 
            // GroupBoxWeekParse
            // 
            GroupBoxWeekParse.Controls.Add(ParseButton);
            GroupBoxWeekParse.Controls.Add(ResultLabel);
            GroupBoxWeekParse.Controls.Add(TextBoxValueParsing);
            GroupBoxWeekParse.Controls.Add(ParsingValueLabel);
            GroupBoxWeekParse.Location = new Point(8, 348);
            GroupBoxWeekParse.Name = "GroupBoxWeekParse";
            GroupBoxWeekParse.Size = new Size(386, 153);
            GroupBoxWeekParse.TabIndex = 0;
            GroupBoxWeekParse.TabStop = false;
            GroupBoxWeekParse.Text = "Weekday parsing";
            // 
            // ParseButton
            // 
            ParseButton.BackColor = Color.LightGray;
            ParseButton.Location = new Point(274, 63);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 2;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = false;
            ParseButton.Click += ParseButton_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(6, 95);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(49, 20);
            ResultLabel.TabIndex = 8;
            ResultLabel.Text = "Result";
            // 
            // TextBoxValueParsing
            // 
            TextBoxValueParsing.Location = new Point(6, 65);
            TextBoxValueParsing.Name = "TextBoxValueParsing";
            TextBoxValueParsing.Size = new Size(264, 27);
            TextBoxValueParsing.TabIndex = 5;
            // 
            // ParsingValueLabel
            // 
            ParsingValueLabel.AutoSize = true;
            ParsingValueLabel.Location = new Point(6, 42);
            ParsingValueLabel.Name = "ParsingValueLabel";
            ParsingValueLabel.Size = new Size(158, 20);
            ParsingValueLabel.TabIndex = 7;
            ParsingValueLabel.Text = "Type value for parsing:";
            // 
            // GroupBoxSeason
            // 
            GroupBoxSeason.Controls.Add(ComboBoxSeason);
            GroupBoxSeason.Controls.Add(SeasonLabel);
            GroupBoxSeason.Controls.Add(GoButton);
            GroupBoxSeason.Location = new Point(400, 348);
            GroupBoxSeason.Name = "GroupBoxSeason";
            GroupBoxSeason.Size = new Size(394, 153);
            GroupBoxSeason.TabIndex = 0;
            GroupBoxSeason.TabStop = false;
            GroupBoxSeason.Text = "Season handle";
            // 
            // ComboBoxSeason
            // 
            ComboBoxSeason.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSeason.FormattingEnabled = true;
            ComboBoxSeason.Items.AddRange(new object[] { "Winter", "Autumn", "Summer", "Spring" });
            ComboBoxSeason.Location = new Point(6, 66);
            ComboBoxSeason.Name = "ComboBoxSeason";
            ComboBoxSeason.Size = new Size(264, 28);
            ComboBoxSeason.TabIndex = 1;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(6, 42);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(107, 20);
            SeasonLabel.TabIndex = 9;
            SeasonLabel.Text = "Choose season";
            // 
            // GoButton
            // 
            GoButton.BackColor = Color.LightGray;
            GoButton.Location = new Point(276, 65);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 29);
            GoButton.TabIndex = 1;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = false;
            GoButton.Click += GoButton_Click;
            // 
            // GroupBoxListBox
            // 
            GroupBoxListBox.Controls.Add(ValuesListBox);
            GroupBoxListBox.Controls.Add(EnumsListBox);
            GroupBoxListBox.Controls.Add(EnumsListBoxLabel);
            GroupBoxListBox.Controls.Add(ValuesListBoxLabel);
            GroupBoxListBox.Location = new Point(0, 0);
            GroupBoxListBox.Name = "GroupBoxListBox";
            GroupBoxListBox.Size = new Size(394, 342);
            GroupBoxListBox.TabIndex = 3;
            GroupBoxListBox.TabStop = false;
            GroupBoxListBox.Text = "Enumerations";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(219, 64);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(157, 264);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Colors", "StudyForm", "Genre", "PhoneCreatoes", "Seasons", "Weekday" });
            EnumsListBox.Location = new Point(8, 64);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(157, 264);
            EnumsListBox.TabIndex = 2;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // EnumsListBoxLabel
            // 
            EnumsListBoxLabel.AutoSize = true;
            EnumsListBoxLabel.Location = new Point(8, 41);
            EnumsListBoxLabel.Name = "EnumsListBoxLabel";
            EnumsListBoxLabel.Size = new Size(149, 20);
            EnumsListBoxLabel.TabIndex = 5;
            EnumsListBoxLabel.Text = "Choose enumaration:";
            // 
            // ValuesListBoxLabel
            // 
            ValuesListBoxLabel.AutoSize = true;
            ValuesListBoxLabel.Location = new Point(219, 41);
            ValuesListBoxLabel.Name = "ValuesListBoxLabel";
            ValuesListBoxLabel.Size = new Size(100, 20);
            ValuesListBoxLabel.TabIndex = 6;
            ValuesListBoxLabel.Text = "Choose value:";
            // 
            // tabPageClasses
            // 
            tabPageClasses.Controls.Add(FilmClassesGroupBox);
            tabPageClasses.Controls.Add(RectangleClassesGroupBox);
            tabPageClasses.Location = new Point(4, 29);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.Padding = new Padding(3);
            tabPageClasses.Size = new Size(844, 497);
            tabPageClasses.TabIndex = 1;
            tabPageClasses.Text = "Classes";
            tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // RectangleClassesGroupBox
            // 
            RectangleClassesGroupBox.Controls.Add(RectangleClassesLabelColor);
            RectangleClassesGroupBox.Controls.Add(RectangleClassesLabelWidth);
            RectangleClassesGroupBox.Controls.Add(RectangleClassesLabelLenght);
            RectangleClassesGroupBox.Controls.Add(RectangleClassesTextBoxWidth);
            RectangleClassesGroupBox.Controls.Add(RectangleClassesTextBoxColor);
            RectangleClassesGroupBox.Controls.Add(RectangleClassesTextBoxLenght);
            RectangleClassesGroupBox.Controls.Add(RectangleClassesFindButton);
            RectangleClassesGroupBox.Controls.Add(RectangleClassesListBox);
            RectangleClassesGroupBox.Location = new Point(3, 0);
            RectangleClassesGroupBox.Name = "RectangleClassesGroupBox";
            RectangleClassesGroupBox.Size = new Size(400, 449);
            RectangleClassesGroupBox.TabIndex = 1;
            RectangleClassesGroupBox.TabStop = false;
            RectangleClassesGroupBox.Text = "Rectangles";
            // 
            // RectangleClassesLabelColor
            // 
            RectangleClassesLabelColor.AutoSize = true;
            RectangleClassesLabelColor.Location = new Point(243, 168);
            RectangleClassesLabelColor.Name = "RectangleClassesLabelColor";
            RectangleClassesLabelColor.Size = new Size(48, 20);
            RectangleClassesLabelColor.TabIndex = 8;
            RectangleClassesLabelColor.Text = "Color:";
            // 
            // RectangleClassesLabelWidth
            // 
            RectangleClassesLabelWidth.AutoSize = true;
            RectangleClassesLabelWidth.Location = new Point(243, 97);
            RectangleClassesLabelWidth.Name = "RectangleClassesLabelWidth";
            RectangleClassesLabelWidth.Size = new Size(52, 20);
            RectangleClassesLabelWidth.TabIndex = 7;
            RectangleClassesLabelWidth.Text = "Width:";
            // 
            // RectangleClassesLabelLenght
            // 
            RectangleClassesLabelLenght.AutoSize = true;
            RectangleClassesLabelLenght.Location = new Point(243, 26);
            RectangleClassesLabelLenght.Name = "RectangleClassesLabelLenght";
            RectangleClassesLabelLenght.Size = new Size(57, 20);
            RectangleClassesLabelLenght.TabIndex = 6;
            RectangleClassesLabelLenght.Text = "Lenght:";
            // 
            // RectangleClassesTextBoxWidth
            // 
            RectangleClassesTextBoxWidth.Location = new Point(243, 120);
            RectangleClassesTextBoxWidth.Name = "RectangleClassesTextBoxWidth";
            RectangleClassesTextBoxWidth.Size = new Size(125, 27);
            RectangleClassesTextBoxWidth.TabIndex = 5;
            // 
            // RectangleClassesTextBoxColor
            // 
            RectangleClassesTextBoxColor.Location = new Point(243, 191);
            RectangleClassesTextBoxColor.Name = "RectangleClassesTextBoxColor";
            RectangleClassesTextBoxColor.Size = new Size(125, 27);
            RectangleClassesTextBoxColor.TabIndex = 4;
            // 
            // RectangleClassesTextBoxLenght
            // 
            RectangleClassesTextBoxLenght.Location = new Point(243, 49);
            RectangleClassesTextBoxLenght.Name = "RectangleClassesTextBoxLenght";
            RectangleClassesTextBoxLenght.Size = new Size(125, 27);
            RectangleClassesTextBoxLenght.TabIndex = 3;
            // 
            // RectangleClassesFindButton
            // 
            RectangleClassesFindButton.Location = new Point(243, 341);
            RectangleClassesFindButton.Name = "RectangleClassesFindButton";
            RectangleClassesFindButton.Size = new Size(94, 29);
            RectangleClassesFindButton.TabIndex = 2;
            RectangleClassesFindButton.Text = "Find";
            RectangleClassesFindButton.UseVisualStyleBackColor = true;
            // 
            // RectangleClassesListBox
            // 
            RectangleClassesListBox.FormattingEnabled = true;
            RectangleClassesListBox.Location = new Point(6, 26);
            RectangleClassesListBox.Name = "RectangleClassesListBox";
            RectangleClassesListBox.Size = new Size(195, 344);
            RectangleClassesListBox.TabIndex = 0;
            // 
            // FilmClassesGroupBox
            // 
            FilmClassesGroupBox.Controls.Add(FilmClassesLabelRating);
            FilmClassesGroupBox.Controls.Add(FilmClassesLabelGenre);
            FilmClassesGroupBox.Controls.Add(FilmClassesTextBoxRating);
            FilmClassesGroupBox.Controls.Add(FilmClassesTextBoxGenre);
            FilmClassesGroupBox.Controls.Add(FilmClassesLabelYear);
            FilmClassesGroupBox.Controls.Add(FilmClassesLabelDuration);
            FilmClassesGroupBox.Controls.Add(FilmClassesLabelName);
            FilmClassesGroupBox.Controls.Add(FilmClassesTextBoxDuration);
            FilmClassesGroupBox.Controls.Add(FilmClassesTextBoxYear);
            FilmClassesGroupBox.Controls.Add(FilmClassesTextBoxName);
            FilmClassesGroupBox.Controls.Add(FilmClassesFindButton);
            FilmClassesGroupBox.Controls.Add(FilmClassesListBox);
            FilmClassesGroupBox.Location = new Point(409, 3);
            FilmClassesGroupBox.Name = "FilmClassesGroupBox";
            FilmClassesGroupBox.Size = new Size(435, 446);
            FilmClassesGroupBox.TabIndex = 9;
            FilmClassesGroupBox.TabStop = false;
            FilmClassesGroupBox.Text = "Film";
            // 
            // FilmClassesLabelYear
            // 
            FilmClassesLabelYear.AutoSize = true;
            FilmClassesLabelYear.Location = new Point(243, 132);
            FilmClassesLabelYear.Name = "FilmClassesLabelYear";
            FilmClassesLabelYear.Size = new Size(40, 20);
            FilmClassesLabelYear.TabIndex = 8;
            FilmClassesLabelYear.Text = "Year:";
            // 
            // FilmClassesLabelDuration
            // 
            FilmClassesLabelDuration.AutoSize = true;
            FilmClassesLabelDuration.Location = new Point(243, 79);
            FilmClassesLabelDuration.Name = "FilmClassesLabelDuration";
            FilmClassesLabelDuration.Size = new Size(100, 20);
            FilmClassesLabelDuration.TabIndex = 7;
            FilmClassesLabelDuration.Text = "Film duration:";
            // 
            // FilmClassesLabelName
            // 
            FilmClassesLabelName.AutoSize = true;
            FilmClassesLabelName.Location = new Point(243, 26);
            FilmClassesLabelName.Name = "FilmClassesLabelName";
            FilmClassesLabelName.Size = new Size(81, 20);
            FilmClassesLabelName.TabIndex = 6;
            FilmClassesLabelName.Text = "Film name:";
            // 
            // FilmClassesTextBoxDuration
            // 
            FilmClassesTextBoxDuration.Location = new Point(243, 102);
            FilmClassesTextBoxDuration.Name = "FilmClassesTextBoxDuration";
            FilmClassesTextBoxDuration.Size = new Size(125, 27);
            FilmClassesTextBoxDuration.TabIndex = 5;
            // 
            // FilmClassesTextBoxYear
            // 
            FilmClassesTextBoxYear.Location = new Point(243, 155);
            FilmClassesTextBoxYear.Name = "FilmClassesTextBoxYear";
            FilmClassesTextBoxYear.Size = new Size(125, 27);
            FilmClassesTextBoxYear.TabIndex = 4;
            // 
            // FilmClassesTextBoxName
            // 
            FilmClassesTextBoxName.Location = new Point(243, 49);
            FilmClassesTextBoxName.Name = "FilmClassesTextBoxName";
            FilmClassesTextBoxName.Size = new Size(125, 27);
            FilmClassesTextBoxName.TabIndex = 3;
            // 
            // FilmClassesFindButton
            // 
            FilmClassesFindButton.Location = new Point(243, 341);
            FilmClassesFindButton.Name = "FilmClassesFindButton";
            FilmClassesFindButton.Size = new Size(94, 29);
            FilmClassesFindButton.TabIndex = 2;
            FilmClassesFindButton.Text = "Find";
            FilmClassesFindButton.UseVisualStyleBackColor = true;
            // 
            // FilmClassesListBox
            // 
            FilmClassesListBox.FormattingEnabled = true;
            FilmClassesListBox.Location = new Point(6, 26);
            FilmClassesListBox.Name = "FilmClassesListBox";
            FilmClassesListBox.Size = new Size(195, 344);
            FilmClassesListBox.TabIndex = 0;
            // 
            // FilmClassesTextBoxGenre
            // 
            FilmClassesTextBoxGenre.Location = new Point(243, 208);
            FilmClassesTextBoxGenre.Name = "FilmClassesTextBoxGenre";
            FilmClassesTextBoxGenre.Size = new Size(125, 27);
            FilmClassesTextBoxGenre.TabIndex = 9;
            // 
            // FilmClassesTextBoxRating
            // 
            FilmClassesTextBoxRating.Location = new Point(243, 261);
            FilmClassesTextBoxRating.Name = "FilmClassesTextBoxRating";
            FilmClassesTextBoxRating.Size = new Size(125, 27);
            FilmClassesTextBoxRating.TabIndex = 10;
            // 
            // FilmClassesLabelGenre
            // 
            FilmClassesLabelGenre.AutoSize = true;
            FilmClassesLabelGenre.Location = new Point(243, 185);
            FilmClassesLabelGenre.Name = "FilmClassesLabelGenre";
            FilmClassesLabelGenre.Size = new Size(51, 20);
            FilmClassesLabelGenre.TabIndex = 11;
            FilmClassesLabelGenre.Text = "Genre:";
            // 
            // FilmClassesLabelRating
            // 
            FilmClassesLabelRating.AutoSize = true;
            FilmClassesLabelRating.Location = new Point(243, 238);
            FilmClassesLabelRating.Name = "FilmClassesLabelRating";
            FilmClassesLabelRating.Size = new Size(55, 20);
            FilmClassesLabelRating.TabIndex = 12;
            FilmClassesLabelRating.Text = "Rating:";
            // 
            // Form1
            // 
            ClientSize = new Size(852, 530);
            Controls.Add(TabControlMain);
            Name = "Form1";
            Text = "Programming";
            Load += Form1_Load;
            TabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            GroupBoxWeekParse.ResumeLayout(false);
            GroupBoxWeekParse.PerformLayout();
            GroupBoxSeason.ResumeLayout(false);
            GroupBoxSeason.PerformLayout();
            GroupBoxListBox.ResumeLayout(false);
            GroupBoxListBox.PerformLayout();
            tabPageClasses.ResumeLayout(false);
            RectangleClassesGroupBox.ResumeLayout(false);
            RectangleClassesGroupBox.PerformLayout();
            FilmClassesGroupBox.ResumeLayout(false);
            FilmClassesGroupBox.PerformLayout();
            ResumeLayout(false);

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
                deafault:
                    break;
            }
        }

        private void ComboBoxSeason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
