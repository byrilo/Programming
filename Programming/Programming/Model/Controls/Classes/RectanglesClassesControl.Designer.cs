namespace Programming.Model.Controls
{
    partial class RectanglesClassesControl
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
            RectangleClassesGroupBox.SuspendLayout();
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
            // RectanglesClassesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectangleClassesGroupBox);
            Name = "RectanglesClassesControl";
            Size = new Size(417, 497);
            Load += ClassesControl_Load;
            RectangleClassesGroupBox.ResumeLayout(false);
            RectangleClassesGroupBox.PerformLayout();
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
    }
}
