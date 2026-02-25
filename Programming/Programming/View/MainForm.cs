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
        private GroupBox groupBox1;
        private Label ColorLabelClasses;
        private Label WidthLabelClasses;
        private Label LenghtLabelClasses;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
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
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            LenghtLabelClasses = new Label();
            WidthLabelClasses = new Label();
            ColorLabelClasses = new Label();
            TabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            GroupBoxWeekParse.SuspendLayout();
            GroupBoxSeason.SuspendLayout();
            GroupBoxListBox.SuspendLayout();
            tabPageClasses.SuspendLayout();
            groupBox1.SuspendLayout();
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
            tabPageClasses.Controls.Add(groupBox1);
            tabPageClasses.Location = new Point(4, 29);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.Padding = new Padding(3);
            tabPageClasses.Size = new Size(844, 497);
            tabPageClasses.TabIndex = 1;
            tabPageClasses.Text = "Classes";
            tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 344);
            listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ColorLabelClasses);
            groupBox1.Controls.Add(WidthLabelClasses);
            groupBox1.Controls.Add(LenghtLabelClasses);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 418);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangles";
            // 
            // button1
            // 
            button1.Location = new Point(243, 341);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(243, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // LenghtLabelClasses
            // 
            LenghtLabelClasses.AutoSize = true;
            LenghtLabelClasses.Location = new Point(243, 26);
            LenghtLabelClasses.Name = "LenghtLabelClasses";
            LenghtLabelClasses.Size = new Size(57, 20);
            LenghtLabelClasses.TabIndex = 6;
            LenghtLabelClasses.Text = "Lenght:";
            // 
            // WidthLabelClasses
            // 
            WidthLabelClasses.AutoSize = true;
            WidthLabelClasses.Location = new Point(243, 97);
            WidthLabelClasses.Name = "WidthLabelClasses";
            WidthLabelClasses.Size = new Size(52, 20);
            WidthLabelClasses.TabIndex = 7;
            WidthLabelClasses.Text = "Width:";
            // 
            // ColorLabelClasses
            // 
            ColorLabelClasses.AutoSize = true;
            ColorLabelClasses.Location = new Point(243, 168);
            ColorLabelClasses.Name = "ColorLabelClasses";
            ColorLabelClasses.Size = new Size(48, 20);
            ColorLabelClasses.TabIndex = 8;
            ColorLabelClasses.Text = "Color:";
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
