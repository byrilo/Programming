namespace Programming.Model.Controls
{
    partial class FilmClassesControl
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
            FilmClassesGroupBox.SuspendLayout();
            SuspendLayout();
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
            FilmClassesGroupBox.Location = new Point(3, 3);
            FilmClassesGroupBox.Name = "FilmClassesGroupBox";
            FilmClassesGroupBox.Size = new Size(435, 486);
            FilmClassesGroupBox.TabIndex = 11;
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
            // FilmClassesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilmClassesGroupBox);
            Name = "FilmClassesControl";
            Size = new Size(451, 489);
            Load += FilmClassesControl_Load;
            FilmClassesGroupBox.ResumeLayout(false);
            FilmClassesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
