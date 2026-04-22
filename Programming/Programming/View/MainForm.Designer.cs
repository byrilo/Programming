namespace Programming
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            tabPageRectangles = new TabPage();
            rectanglesCollisionControl1 = new Programming.Model.Controls.RectanglesCollisionControl();
            filmClassesControl1 = new Programming.Model.Controls.FilmClassesControl();
            rectanglesClassesControl1 = new Programming.Model.Controls.RectanglesClassesControl();
            TabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            GroupBoxWeekParse.SuspendLayout();
            GroupBoxSeason.SuspendLayout();
            GroupBoxListBox.SuspendLayout();
            tabPageClasses.SuspendLayout();
            tabPageRectangles.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlMain
            // 
            TabControlMain.Controls.Add(tabPage1);
            TabControlMain.Controls.Add(tabPageClasses);
            TabControlMain.Controls.Add(tabPageRectangles);
            TabControlMain.Dock = DockStyle.Fill;
            TabControlMain.Location = new Point(0, 0);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(1177, 530);
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
            tabPage1.Size = new Size(1169, 497);
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
            tabPageClasses.Controls.Add(rectanglesClassesControl1);
            tabPageClasses.Controls.Add(filmClassesControl1);
            tabPageClasses.Location = new Point(4, 29);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.Padding = new Padding(3);
            tabPageClasses.Size = new Size(1169, 497);
            tabPageClasses.TabIndex = 1;
            tabPageClasses.Text = "Classes";
            tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // tabPageRectangles
            // 
            tabPageRectangles.Controls.Add(rectanglesCollisionControl1);
            tabPageRectangles.Location = new Point(4, 29);
            tabPageRectangles.Name = "tabPageRectangles";
            tabPageRectangles.Padding = new Padding(3);
            tabPageRectangles.Size = new Size(1169, 497);
            tabPageRectangles.TabIndex = 3;
            tabPageRectangles.Text = "Rectangles";
            tabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Location = new Point(0, 0);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(1169, 501);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // filmClassesControl1
            // 
            filmClassesControl1.Location = new Point(536, 6);
            filmClassesControl1.Name = "filmClassesControl1";
            filmClassesControl1.Size = new Size(564, 611);
            filmClassesControl1.TabIndex = 0;
            // 
            // rectanglesClassesControl1
            // 
            rectanglesClassesControl1.Location = new Point(0, 3);
            rectanglesClassesControl1.Name = "rectanglesClassesControl1";
            rectanglesClassesControl1.Size = new Size(521, 621);
            rectanglesClassesControl1.TabIndex = 1;
            // 
            // Form1
            // 
            ClientSize = new Size(1177, 530);
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
            tabPageRectangles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ?? Объявления полей элементов управления
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
        private ComboBox ComboBoxSeason;
        private TabPage tabPageRectangles;
        private Model.Controls.RectanglesCollisionControl rectanglesCollisionControl1;
        private TabPage tabPageClasses;
        private Model.Controls.RectanglesClassesControl rectanglesClassesControl1;
        private Model.Controls.FilmClassesControl filmClassesControl1;
    }
}