namespace Programming.Model.Controls
{
    partial class ClassesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
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
            RectangleClassesGroupBox.SuspendLayout();
            FilmClassesGroupBox.SuspendLayout();
            SuspendLayout();
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
            RectangleClassesGroupBox.Location = new Point(3, 3);
            RectangleClassesGroupBox.Name = "RectangleClassesGroupBox";
            RectangleClassesGroupBox.Size = new Size(406, 489);
            RectangleClassesGroupBox.TabIndex = 2;
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
            RectangleClassesFindButton.TextChanged += RectangleClassesFindButton_Click;
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
            FilmClassesGroupBox.Location = new Point(415, 8);
            FilmClassesGroupBox.Name = "FilmClassesGroupBox";
            FilmClassesGroupBox.Size = new Size(435, 486);
            FilmClassesGroupBox.TabIndex = 10;
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
            FilmClassesFindButton.TextChanged += FilmClassesFindButton_Click;
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
            // ClassesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilmClassesGroupBox);
            Controls.Add(RectangleClassesGroupBox);
            Name = "ClassesControl";
            Size = new Size(884, 505);
            Load += ClassesControl_Load;
            RectangleClassesGroupBox.ResumeLayout(false);
            RectangleClassesGroupBox.PerformLayout();
            FilmClassesGroupBox.ResumeLayout(false);
            FilmClassesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private Label FilmClassesLabelRating;
        private Label FilmClassesLabelGenre;
        private TextBox FilmClassesTextBoxRating;
        private TextBox FilmClassesTextBoxGenre;
        private Label FilmClassesLabelYear;
        private Label FilmClassesLabelDuration;
        private TextBox FilmClassesTextBoxDuration;
        private TextBox FilmClassesTextBoxYear;
        private Button FilmClassesFindButton;
        private ListBox FilmClassesListBox;
    }
}
