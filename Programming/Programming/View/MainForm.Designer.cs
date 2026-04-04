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
            buttonRectanglesDelete = new Button();
            buttonRectanglesAdd = new Button();
            labelRectangles = new Label();
            labelLength = new Label();
            labelWidth = new Label();
            labelSelectedRectangle = new Label();
            CanvasPanel = new Panel();
            listBoxRectangles = new ListBox();
            labelID = new Label();
            labelCenterY = new Label();
            labelCenterX = new Label();
            textBoxLength = new TextBox();
            textBoxWidth = new TextBox();
            textBoxID = new TextBox();
            textBoxCenterY = new TextBox();
            textBoxCenterX = new TextBox();
            TabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            GroupBoxWeekParse.SuspendLayout();
            GroupBoxSeason.SuspendLayout();
            GroupBoxListBox.SuspendLayout();
            tabPageClasses.SuspendLayout();
            FilmClassesGroupBox.SuspendLayout();
            RectangleClassesGroupBox.SuspendLayout();
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
            tabPageClasses.Controls.Add(FilmClassesGroupBox);
            tabPageClasses.Controls.Add(RectangleClassesGroupBox);
            tabPageClasses.Location = new Point(4, 29);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.Padding = new Padding(3);
            tabPageClasses.Size = new Size(1169, 497);
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
            tabPageRectangles.Controls.Add(buttonRectanglesDelete);
            tabPageRectangles.Controls.Add(buttonRectanglesAdd);
            tabPageRectangles.Controls.Add(labelRectangles);
            tabPageRectangles.Controls.Add(labelLength);
            tabPageRectangles.Controls.Add(labelWidth);
            tabPageRectangles.Controls.Add(labelSelectedRectangle);
            tabPageRectangles.Controls.Add(CanvasPanel);
            tabPageRectangles.Controls.Add(listBoxRectangles);
            tabPageRectangles.Controls.Add(labelID);
            tabPageRectangles.Controls.Add(labelCenterY);
            tabPageRectangles.Controls.Add(labelCenterX);
            tabPageRectangles.Controls.Add(textBoxLength);
            tabPageRectangles.Controls.Add(textBoxWidth);
            tabPageRectangles.Controls.Add(textBoxID);
            tabPageRectangles.Controls.Add(textBoxCenterY);
            tabPageRectangles.Controls.Add(textBoxCenterX);
            tabPageRectangles.Location = new Point(4, 29);
            tabPageRectangles.Name = "tabPageRectangles";
            tabPageRectangles.Padding = new Padding(3);
            tabPageRectangles.Size = new Size(1169, 497);
            tabPageRectangles.TabIndex = 3;
            tabPageRectangles.Text = "Rectangles";
            tabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // buttonRectanglesDelete
            // 
            buttonRectanglesDelete.FlatAppearance.BorderSize = 0;
            buttonRectanglesDelete.FlatStyle = FlatStyle.Flat;
            buttonRectanglesDelete.Location = new Point(359, 221);
            buttonRectanglesDelete.Name = "buttonRectanglesDelete";
            buttonRectanglesDelete.Size = new Size(65, 29);
            buttonRectanglesDelete.TabIndex = 15;
            buttonRectanglesDelete.Text = "Delete";
            buttonRectanglesDelete.UseVisualStyleBackColor = true;
            // 
            // buttonRectanglesAdd
            // 
            buttonRectanglesAdd.FlatAppearance.BorderSize = 0;
            buttonRectanglesAdd.FlatStyle = FlatStyle.Flat;
            buttonRectanglesAdd.Location = new Point(300, 221);
            buttonRectanglesAdd.Name = "buttonRectanglesAdd";
            buttonRectanglesAdd.Size = new Size(53, 29);
            buttonRectanglesAdd.TabIndex = 14;
            buttonRectanglesAdd.Text = "Add";
            buttonRectanglesAdd.UseVisualStyleBackColor = true;
            buttonRectanglesAdd.Click += buttonRectanglesAdd_Click;
            // 
            // labelRectangles
            // 
            labelRectangles.AutoSize = true;
            labelRectangles.Location = new Point(31, -2);
            labelRectangles.Name = "labelRectangles";
            labelRectangles.Size = new Size(84, 20);
            labelRectangles.TabIndex = 13;
            labelRectangles.Text = "Rectangles:";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(38, 365);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(57, 20);
            labelLength.TabIndex = 12;
            labelLength.Text = "Length:";
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(43, 395);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(52, 20);
            labelWidth.TabIndex = 11;
            labelWidth.Text = "Width:";
            // 
            // labelSelectedRectangle
            // 
            labelSelectedRectangle.AutoSize = true;
            labelSelectedRectangle.Location = new Point(31, 225);
            labelSelectedRectangle.Name = "labelSelectedRectangle";
            labelSelectedRectangle.Size = new Size(139, 20);
            labelSelectedRectangle.TabIndex = 10;
            labelSelectedRectangle.Text = "Selected Rectangle:";
            // 
            // CanvasPanel
            // 
            CanvasPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Location = new Point(430, 21);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(731, 457);
            CanvasPanel.TabIndex = 9;
            // 
            // listBoxRectangles
            // 
            listBoxRectangles.FormattingEnabled = true;
            listBoxRectangles.Location = new Point(31, 21);
            listBoxRectangles.Name = "listBoxRectangles";
            listBoxRectangles.Size = new Size(393, 184);
            listBoxRectangles.TabIndex = 8;
            listBoxRectangles.SelectedIndexChanged += listBoxRectangles_SelectedIndexChanged;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(71, 329);
            labelID.Name = "labelID";
            labelID.Size = new Size(27, 20);
            labelID.TabIndex = 7;
            labelID.Text = "ID:";
            // 
            // labelCenterY
            // 
            labelCenterY.AutoSize = true;
            labelCenterY.Location = new Point(75, 296);
            labelCenterY.Name = "labelCenterY";
            labelCenterY.Size = new Size(20, 20);
            labelCenterY.TabIndex = 6;
            labelCenterY.Text = "Y:";
            // 
            // labelCenterX
            // 
            labelCenterX.AutoSize = true;
            labelCenterX.Location = new Point(74, 267);
            labelCenterX.Name = "labelCenterX";
            labelCenterX.Size = new Size(21, 20);
            labelCenterX.TabIndex = 5;
            labelCenterX.Text = "X:";
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(101, 362);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(125, 27);
            textBoxLength.TabIndex = 4;
            textBoxLength.TextChanged += textBoxLength_TextChanged;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(101, 392);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(125, 27);
            textBoxWidth.TabIndex = 3;
            textBoxWidth.TextChanged += textBoxWidth_TextChanged;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(101, 326);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 2;
            // 
            // textBoxCenterY
            // 
            textBoxCenterY.Location = new Point(101, 293);
            textBoxCenterY.Name = "textBoxCenterY";
            textBoxCenterY.ReadOnly = true;
            textBoxCenterY.Size = new Size(125, 27);
            textBoxCenterY.TabIndex = 1;
            // 
            // textBoxCenterX
            // 
            textBoxCenterX.Location = new Point(101, 260);
            textBoxCenterX.Name = "textBoxCenterX";
            textBoxCenterX.ReadOnly = true;
            textBoxCenterX.Size = new Size(125, 27);
            textBoxCenterX.TabIndex = 0;
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
            FilmClassesGroupBox.ResumeLayout(false);
            FilmClassesGroupBox.PerformLayout();
            RectangleClassesGroupBox.ResumeLayout(false);
            RectangleClassesGroupBox.PerformLayout();
            tabPageRectangles.ResumeLayout(false);
            tabPageRectangles.PerformLayout();
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
        private TextBox textBoxLength;
        private TextBox textBoxWidth;
        private TextBox textBoxID;
        private TextBox textBoxCenterY;
        private TextBox textBoxCenterX;
        private Label labelCenterY;
        private Label labelCenterX;
        private Label labelID;
        private Panel CanvasPanel;
        private ListBox listBoxRectangles;
        private Label labelSelectedRectangle;
        private Label labelRectangles;
        private Label labelLength;
        private Label labelWidth;
        private Button buttonRectanglesAdd;
        private Button buttonRectanglesDelete;
    }
}