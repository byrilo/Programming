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
            components = new System.ComponentModel.Container();
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
            FilmClassesGroupBox = new GroupBox();
            FilmClassesLabelRating = new Label();
            FilmClassesLabelGenre = new Label();
            FilmClassesTextBoxRating = new TextBox();
            FilmClassesTextBoxGenre = new TextBox();
            FilmClassesLabelYear = new Label();
            FilmClassesLabelDuration = new Label();
            FilmClassesTextBoxDuration = new TextBox();
            FilmClassesTextBoxYear = new TextBox();
            FilmClassesFindButton = new Button();
            FilmClassesListBox = new ListBox();
            RectangleClassesGroupBox = new GroupBox();
            RectangleClassesLabelColor = new Label();
            RectangleClassesLabelWidth = new Label();
            RectangleClassesLabelLenght = new Label();
            RectangleClassesTextBoxWidth = new TextBox();
            RectangleClassesTextBoxColor = new TextBox();
            RectangleClassesTextBoxLenght = new TextBox();
            RectangleClassesFindButton = new Button();
            RectangleClassesListBox = new ListBox();
            tabPageRectangles = new TabPage();
            tabPageRings = new TabPage();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelName = new Label();
            labelSurname = new Label();
            label3 = new Label();
            TabPageContacts = new TabPage();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            TabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            GroupBoxWeekParse.SuspendLayout();
            GroupBoxSeason.SuspendLayout();
            GroupBoxListBox.SuspendLayout();
            tabPageClasses.SuspendLayout();
            FilmClassesGroupBox.SuspendLayout();
            RectangleClassesGroupBox.SuspendLayout();
            tabPageRectangles.SuspendLayout();
            TabPageContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // TabControlMain
            // 
            TabControlMain.Controls.Add(tabPage1);
            TabControlMain.Controls.Add(tabPageClasses);
            TabControlMain.Controls.Add(TabPageContacts);
            TabControlMain.Controls.Add(tabPageRectangles);
            TabControlMain.Controls.Add(tabPageRings);
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
            // FilmClassesGroupBox
            // 
            FilmClassesGroupBox.Controls.Add(FilmClassesLabelRating);
            FilmClassesGroupBox.Controls.Add(FilmClassesLabelGenre);
            FilmClassesGroupBox.Controls.Add(FilmClassesTextBoxRating);
            FilmClassesGroupBox.Controls.Add(FilmClassesTextBoxGenre);
            FilmClassesGroupBox.Controls.Add(FilmClassesLabelYear);
            FilmClassesGroupBox.Controls.Add(FilmClassesLabelDuration);
            FilmClassesGroupBox.Controls.Add(FilmClassesTextBoxDuration);
            FilmClassesGroupBox.Controls.Add(FilmClassesTextBoxYear);
            FilmClassesGroupBox.Controls.Add(FilmClassesFindButton);
            FilmClassesGroupBox.Controls.Add(FilmClassesListBox);
            FilmClassesGroupBox.Location = new Point(409, 3);
            FilmClassesGroupBox.Name = "FilmClassesGroupBox";
            FilmClassesGroupBox.Size = new Size(435, 486);
            FilmClassesGroupBox.TabIndex = 9;
            FilmClassesGroupBox.TabStop = false;
            FilmClassesGroupBox.Text = "Film";
            // 
            // FilmClassesLabelRating
            // 
            FilmClassesLabelRating.AutoSize = true;
            FilmClassesLabelRating.Location = new Point(243, 185);
            FilmClassesLabelRating.Name = "FilmClassesLabelRating";
            FilmClassesLabelRating.Size = new Size(55, 20);
            FilmClassesLabelRating.TabIndex = 12;
            FilmClassesLabelRating.Text = "Rating:";
            // 
            // FilmClassesLabelGenre
            // 
            FilmClassesLabelGenre.AutoSize = true;
            FilmClassesLabelGenre.Location = new Point(243, 132);
            FilmClassesLabelGenre.Name = "FilmClassesLabelGenre";
            FilmClassesLabelGenre.Size = new Size(51, 20);
            FilmClassesLabelGenre.TabIndex = 11;
            FilmClassesLabelGenre.Text = "Genre:";
            // 
            // FilmClassesTextBoxRating
            // 
            FilmClassesTextBoxRating.Location = new Point(243, 208);
            FilmClassesTextBoxRating.Name = "FilmClassesTextBoxRating";
            FilmClassesTextBoxRating.Size = new Size(125, 27);
            FilmClassesTextBoxRating.TabIndex = 10;
            FilmClassesTextBoxRating.TextChanged += FilmClassesTextBoxRating_TextChanged;
            // 
            // FilmClassesTextBoxGenre
            // 
            FilmClassesTextBoxGenre.Location = new Point(243, 155);
            FilmClassesTextBoxGenre.Name = "FilmClassesTextBoxGenre";
            FilmClassesTextBoxGenre.Size = new Size(125, 27);
            FilmClassesTextBoxGenre.TabIndex = 9;
            FilmClassesTextBoxGenre.TextChanged += FilmClassesTextBoxGenre_TextChanged;
            // 
            // FilmClassesLabelYear
            // 
            FilmClassesLabelYear.AutoSize = true;
            FilmClassesLabelYear.Location = new Point(243, 79);
            FilmClassesLabelYear.Name = "FilmClassesLabelYear";
            FilmClassesLabelYear.Size = new Size(40, 20);
            FilmClassesLabelYear.TabIndex = 8;
            FilmClassesLabelYear.Text = "Year:";
            // 
            // FilmClassesLabelDuration
            // 
            FilmClassesLabelDuration.AutoSize = true;
            FilmClassesLabelDuration.Location = new Point(243, 26);
            FilmClassesLabelDuration.Name = "FilmClassesLabelDuration";
            FilmClassesLabelDuration.Size = new Size(100, 20);
            FilmClassesLabelDuration.TabIndex = 7;
            FilmClassesLabelDuration.Text = "Film duration:";
            // 
            // FilmClassesTextBoxDuration
            // 
            FilmClassesTextBoxDuration.Location = new Point(243, 49);
            FilmClassesTextBoxDuration.Name = "FilmClassesTextBoxDuration";
            FilmClassesTextBoxDuration.Size = new Size(125, 27);
            FilmClassesTextBoxDuration.TabIndex = 5;
            FilmClassesTextBoxDuration.TextChanged += FilmClassesTextBoxDuration_TextChanged;
            // 
            // FilmClassesTextBoxYear
            // 
            FilmClassesTextBoxYear.Location = new Point(243, 102);
            FilmClassesTextBoxYear.Name = "FilmClassesTextBoxYear";
            FilmClassesTextBoxYear.Size = new Size(125, 27);
            FilmClassesTextBoxYear.TabIndex = 4;
            FilmClassesTextBoxYear.TextChanged += FilmClassesTextBoxYear_TextChanged;
            // 
            // FilmClassesFindButton
            // 
            FilmClassesFindButton.Location = new Point(243, 341);
            FilmClassesFindButton.Name = "FilmClassesFindButton";
            FilmClassesFindButton.Size = new Size(94, 29);
            FilmClassesFindButton.TabIndex = 2;
            FilmClassesFindButton.Text = "Find";
            FilmClassesFindButton.UseVisualStyleBackColor = true;
            FilmClassesFindButton.Click += FilmClassesFindButton_Click;
            // 
            // FilmClassesListBox
            // 
            FilmClassesListBox.FormattingEnabled = true;
            FilmClassesListBox.Location = new Point(6, 26);
            FilmClassesListBox.Name = "FilmClassesListBox";
            FilmClassesListBox.Size = new Size(231, 344);
            FilmClassesListBox.TabIndex = 0;
            FilmClassesListBox.SelectedIndexChanged += FilmClassesListBox_SelectedIndexChanged;
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
            RectangleClassesGroupBox.Size = new Size(406, 489);
            RectangleClassesGroupBox.TabIndex = 1;
            RectangleClassesGroupBox.TabStop = false;
            RectangleClassesGroupBox.Text = "Rectangles";
            // 
            // RectangleClassesLabelColor
            // 
            RectangleClassesLabelColor.AutoSize = true;
            RectangleClassesLabelColor.Location = new Point(243, 135);
            RectangleClassesLabelColor.Name = "RectangleClassesLabelColor";
            RectangleClassesLabelColor.Size = new Size(48, 20);
            RectangleClassesLabelColor.TabIndex = 8;
            RectangleClassesLabelColor.Text = "Color:";
            // 
            // RectangleClassesLabelWidth
            // 
            RectangleClassesLabelWidth.AutoSize = true;
            RectangleClassesLabelWidth.Location = new Point(243, 79);
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
            RectangleClassesTextBoxWidth.Location = new Point(243, 102);
            RectangleClassesTextBoxWidth.Name = "RectangleClassesTextBoxWidth";
            RectangleClassesTextBoxWidth.Size = new Size(125, 27);
            RectangleClassesTextBoxWidth.TabIndex = 5;
            RectangleClassesTextBoxWidth.TextChanged += RectangleClassesTextBoxWidth_TextChanged;
            // 
            // RectangleClassesTextBoxColor
            // 
            RectangleClassesTextBoxColor.Location = new Point(243, 158);
            RectangleClassesTextBoxColor.Name = "RectangleClassesTextBoxColor";
            RectangleClassesTextBoxColor.Size = new Size(125, 27);
            RectangleClassesTextBoxColor.TabIndex = 4;
            RectangleClassesTextBoxColor.TextChanged += RectangleClassesTextBoxColor_TextChanged;
            // 
            // RectangleClassesTextBoxLenght
            // 
            RectangleClassesTextBoxLenght.Location = new Point(243, 49);
            RectangleClassesTextBoxLenght.Name = "RectangleClassesTextBoxLenght";
            RectangleClassesTextBoxLenght.Size = new Size(125, 27);
            RectangleClassesTextBoxLenght.TabIndex = 3;
            RectangleClassesTextBoxLenght.TextChanged += RectangleClassesTextBoxLenght_TextChanged;
            // 
            // RectangleClassesFindButton
            // 
            RectangleClassesFindButton.Location = new Point(243, 341);
            RectangleClassesFindButton.Name = "RectangleClassesFindButton";
            RectangleClassesFindButton.Size = new Size(94, 29);
            RectangleClassesFindButton.TabIndex = 2;
            RectangleClassesFindButton.Text = "Find";
            RectangleClassesFindButton.UseVisualStyleBackColor = true;
            RectangleClassesFindButton.Click += RectangleClassesFindButton_Click;
            // 
            // RectangleClassesListBox
            // 
            RectangleClassesListBox.FormattingEnabled = true;
            RectangleClassesListBox.Location = new Point(6, 26);
            RectangleClassesListBox.Name = "RectangleClassesListBox";
            RectangleClassesListBox.Size = new Size(231, 344);
            RectangleClassesListBox.TabIndex = 0;
            RectangleClassesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // tabPageRectangles
            // 
            tabPageRectangles.Controls.Add(textBox7);
            tabPageRectangles.Controls.Add(textBox6);
            tabPageRectangles.Controls.Add(textBox5);
            tabPageRectangles.Controls.Add(textBox4);
            tabPageRectangles.Controls.Add(textBox3);
            tabPageRectangles.Location = new Point(4, 29);
            tabPageRectangles.Name = "tabPageRectangles";
            tabPageRectangles.Padding = new Padding(3);
            tabPageRectangles.Size = new Size(844, 497);
            tabPageRectangles.TabIndex = 3;
            tabPageRectangles.Text = "Rectangles";
            tabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // tabPageRings
            // 
            tabPageRings.Location = new Point(4, 29);
            tabPageRings.Name = "tabPageRings";
            tabPageRings.Padding = new Padding(3);
            tabPageRings.Size = new Size(844, 497);
            tabPageRings.TabIndex = 4;
            tabPageRings.Text = "Rings";
            tabPageRings.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 27);
            textBox2.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(33, 49);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(33, 96);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(67, 20);
            labelSurname.TabIndex = 3;
            labelSurname.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 141);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // TabPageContacts
            // 
            TabPageContacts.Controls.Add(label3);
            TabPageContacts.Controls.Add(labelSurname);
            TabPageContacts.Controls.Add(labelName);
            TabPageContacts.Controls.Add(textBox2);
            TabPageContacts.Controls.Add(textBox1);
            TabPageContacts.Location = new Point(4, 29);
            TabPageContacts.Name = "TabPageContacts";
            TabPageContacts.Padding = new Padding(3);
            TabPageContacts.Size = new Size(844, 497);
            TabPageContacts.TabIndex = 2;
            TabPageContacts.Text = "Contacts";
            TabPageContacts.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(113, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(113, 212);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(113, 245);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(113, 278);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 4;
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
            FilmClassesGroupBox.ResumeLayout(false);
            FilmClassesGroupBox.PerformLayout();
            RectangleClassesGroupBox.ResumeLayout(false);
            RectangleClassesGroupBox.PerformLayout();
            tabPageRectangles.ResumeLayout(false);
            tabPageRectangles.PerformLayout();
            TabPageContacts.ResumeLayout(false);
            TabPageContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
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
        private TextBox FilmClassesTextBoxDuration;
        private TextBox FilmClassesTextBoxYear;
        private Button FilmClassesFindButton;
        private ListBox FilmClassesListBox;
        private Label FilmClassesLabelRating;
        private Label FilmClassesLabelGenre;
        private TextBox FilmClassesTextBoxRating;
        private TextBox FilmClassesTextBoxGenre;
        private ComboBox ComboBoxSeason;
        private TabPage tabPageRectangles;
        private TabPage tabPageRings;
        private TabPage TabPageContacts;
        private Label label3;
        private Label labelSurname;
        private Label labelName;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}