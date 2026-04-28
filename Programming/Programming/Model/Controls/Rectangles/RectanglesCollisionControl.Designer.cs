namespace Programming.Model.Controls
{
    partial class RectanglesCollisionControl
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
            CanvasPanel = new Panel();
            listBoxRectangles = new ListBox();
            labelRectangles = new Label();
            labelSelectedRectangle = new Label();
            labelLength = new Label();
            labelWidth = new Label();
            labelID = new Label();
            labelCenterY = new Label();
            labelCenterX = new Label();
            textBoxLength = new TextBox();
            textBoxWidth = new TextBox();
            textBoxID = new TextBox();
            textBoxCenterY = new TextBox();
            textBoxCenterX = new TextBox();
            buttonRectanglesDelete = new Button();
            buttonRectanglesAdd = new Button();
            SuspendLayout();
            // 
            // CanvasPanel
            // 
            CanvasPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Location = new Point(434, 54);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(731, 457);
            CanvasPanel.TabIndex = 10;
            // 
            // listBoxRectangles
            // 
            listBoxRectangles.FormattingEnabled = true;
            listBoxRectangles.Location = new Point(22, 54);
            listBoxRectangles.Name = "listBoxRectangles";
            listBoxRectangles.Size = new Size(393, 184);
            listBoxRectangles.TabIndex = 11;
            listBoxRectangles.SelectedIndexChanged += listBoxRectangles_SelectedIndexChanged;
            // 
            // labelRectangles
            // 
            labelRectangles.AutoSize = true;
            labelRectangles.Location = new Point(22, 31);
            labelRectangles.Name = "labelRectangles";
            labelRectangles.Size = new Size(84, 20);
            labelRectangles.TabIndex = 14;
            labelRectangles.Text = "Rectangles:";
            // 
            // labelSelectedRectangle
            // 
            labelSelectedRectangle.AutoSize = true;
            labelSelectedRectangle.Location = new Point(22, 254);
            labelSelectedRectangle.Name = "labelSelectedRectangle";
            labelSelectedRectangle.Size = new Size(139, 20);
            labelSelectedRectangle.TabIndex = 15;
            labelSelectedRectangle.Text = "Selected Rectangle:";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(34, 396);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(57, 20);
            labelLength.TabIndex = 20;
            labelLength.Text = "Length:";
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(39, 426);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(52, 20);
            labelWidth.TabIndex = 19;
            labelWidth.Text = "Width:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(67, 360);
            labelID.Name = "labelID";
            labelID.Size = new Size(27, 20);
            labelID.TabIndex = 18;
            labelID.Text = "ID:";
            // 
            // labelCenterY
            // 
            labelCenterY.AutoSize = true;
            labelCenterY.Location = new Point(71, 327);
            labelCenterY.Name = "labelCenterY";
            labelCenterY.Size = new Size(20, 20);
            labelCenterY.TabIndex = 17;
            labelCenterY.Text = "Y:";
            // 
            // labelCenterX
            // 
            labelCenterX.AutoSize = true;
            labelCenterX.Location = new Point(70, 298);
            labelCenterX.Name = "labelCenterX";
            labelCenterX.Size = new Size(21, 20);
            labelCenterX.TabIndex = 16;
            labelCenterX.Text = "X:";
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(100, 396);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(125, 27);
            textBoxLength.TabIndex = 25;
            textBoxLength.TextChanged += textBoxLength_TextChanged;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(100, 426);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(125, 27);
            textBoxWidth.TabIndex = 24;
            textBoxWidth.TextChanged += textBoxWidth_TextChanged;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(100, 360);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 23;
            // 
            // textBoxCenterY
            // 
            textBoxCenterY.Location = new Point(100, 327);
            textBoxCenterY.Name = "textBoxCenterY";
            textBoxCenterY.ReadOnly = true;
            textBoxCenterY.Size = new Size(125, 27);
            textBoxCenterY.TabIndex = 22;
            // 
            // textBoxCenterX
            // 
            textBoxCenterX.Location = new Point(100, 294);
            textBoxCenterX.Name = "textBoxCenterX";
            textBoxCenterX.ReadOnly = true;
            textBoxCenterX.Size = new Size(125, 27);
            textBoxCenterX.TabIndex = 21;
            // 
            // buttonRectanglesDelete
            // 
            buttonRectanglesDelete.FlatAppearance.BorderSize = 0;
            buttonRectanglesDelete.FlatStyle = FlatStyle.Flat;
            buttonRectanglesDelete.Location = new Point(347, 254);
            buttonRectanglesDelete.Name = "buttonRectanglesDelete";
            buttonRectanglesDelete.Size = new Size(65, 29);
            buttonRectanglesDelete.TabIndex = 27;
            buttonRectanglesDelete.Text = "Delete";
            buttonRectanglesDelete.UseVisualStyleBackColor = true;
            buttonRectanglesDelete.Click += buttonRectanglesDelete_Click;
            // 
            // buttonRectanglesAdd
            // 
            buttonRectanglesAdd.FlatAppearance.BorderSize = 0;
            buttonRectanglesAdd.FlatStyle = FlatStyle.Flat;
            buttonRectanglesAdd.Location = new Point(288, 254);
            buttonRectanglesAdd.Name = "buttonRectanglesAdd";
            buttonRectanglesAdd.Size = new Size(53, 29);
            buttonRectanglesAdd.TabIndex = 26;
            buttonRectanglesAdd.Text = "Add";
            buttonRectanglesAdd.UseVisualStyleBackColor = true;
            buttonRectanglesAdd.Click += buttonRectanglesAdd_Click;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRectanglesDelete);
            Controls.Add(buttonRectanglesAdd);
            Controls.Add(textBoxLength);
            Controls.Add(textBoxWidth);
            Controls.Add(textBoxID);
            Controls.Add(textBoxCenterY);
            Controls.Add(textBoxCenterX);
            Controls.Add(labelLength);
            Controls.Add(labelWidth);
            Controls.Add(labelID);
            Controls.Add(labelCenterY);
            Controls.Add(labelCenterX);
            Controls.Add(labelSelectedRectangle);
            Controls.Add(labelRectangles);
            Controls.Add(listBoxRectangles);
            Controls.Add(CanvasPanel);
            Name = "RectanglesCollisionControl";
            Size = new Size(1183, 551);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CanvasPanel;
        private ListBox listBoxRectangles;
        private Label labelRectangles;
        private Label labelSelectedRectangle;
        private Label labelLength;
        private Label labelWidth;
        private Label labelID;
        private Label labelCenterY;
        private Label labelCenterX;
        private TextBox textBoxLength;
        private TextBox textBoxWidth;
        private TextBox textBoxID;
        private TextBox textBoxCenterY;
        private TextBox textBoxCenterX;
        private Button buttonRectanglesDelete;
        private Button buttonRectanglesAdd;
    }
}
