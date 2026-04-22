namespace Programming.Model.Controls.Enums
{
    partial class SeasonsHandleEnumControl
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
            GroupBoxSeason = new GroupBox();
            ComboBoxSeason = new ComboBox();
            SeasonLabel = new Label();
            GoButton = new Button();
            GroupBoxSeason.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxSeason
            // 
            GroupBoxSeason.Controls.Add(ComboBoxSeason);
            GroupBoxSeason.Controls.Add(SeasonLabel);
            GroupBoxSeason.Controls.Add(GoButton);
            GroupBoxSeason.Location = new Point(3, 3);
            GroupBoxSeason.Name = "GroupBoxSeason";
            GroupBoxSeason.Size = new Size(394, 153);
            GroupBoxSeason.TabIndex = 1;
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
            // 
            // SeasonsHandleEnumControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupBoxSeason);
            Name = "SeasonsHandleEnumControl";
            Size = new Size(405, 163);
            Load += SeasonsHandleEnumControl_Load;
            GroupBoxSeason.ResumeLayout(false);
            GroupBoxSeason.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxSeason;
        private ComboBox ComboBoxSeason;
        private Label SeasonLabel;
        private Button GoButton;
    }
}
