namespace Programming.Model.Controls
{
    partial class EnumarationsEnumControl
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
            GroupBoxListBox = new GroupBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            EnumsListBoxLabel = new Label();
            ValuesListBoxLabel = new Label();
            IntValueLabel = new Label();
            IntValueTextBox = new TextBox();
            GroupBoxListBox.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxListBox
            // 
            GroupBoxListBox.Controls.Add(ValuesListBox);
            GroupBoxListBox.Controls.Add(EnumsListBox);
            GroupBoxListBox.Controls.Add(EnumsListBoxLabel);
            GroupBoxListBox.Controls.Add(ValuesListBoxLabel);
            GroupBoxListBox.Location = new Point(3, 3);
            GroupBoxListBox.Name = "GroupBoxListBox";
            GroupBoxListBox.Size = new Size(394, 342);
            GroupBoxListBox.TabIndex = 4;
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
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(403, 44);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(68, 20);
            IntValueLabel.TabIndex = 8;
            IntValueLabel.Text = "Int value:";
            // 
            // IntValueTextBox
            // 
            IntValueTextBox.Location = new Point(403, 67);
            IntValueTextBox.Name = "IntValueTextBox";
            IntValueTextBox.ReadOnly = true;
            IntValueTextBox.Size = new Size(264, 27);
            IntValueTextBox.TabIndex = 7;
            // 
            // EnumarationsEnumControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IntValueLabel);
            Controls.Add(IntValueTextBox);
            Controls.Add(GroupBoxListBox);
            Name = "EnumarationsEnumControl";
            Size = new Size(683, 362);
            Load += EnumarationsEnumControl_Load;
            GroupBoxListBox.ResumeLayout(false);
            GroupBoxListBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GroupBoxListBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label EnumsListBoxLabel;
        private Label ValuesListBoxLabel;
        private Label IntValueLabel;
        private TextBox IntValueTextBox;
    }
}
