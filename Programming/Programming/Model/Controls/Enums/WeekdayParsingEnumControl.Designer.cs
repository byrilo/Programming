namespace Programming.Model.Controls.Enums
{
    partial class WeekdayParsingEnumControl
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
            GroupBoxWeekParse = new GroupBox();
            ParseButton = new Button();
            ResultLabel = new Label();
            TextBoxValueParsing = new TextBox();
            ParsingValueLabel = new Label();
            GroupBoxWeekParse.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxWeekParse
            // 
            GroupBoxWeekParse.Controls.Add(ParseButton);
            GroupBoxWeekParse.Controls.Add(ResultLabel);
            GroupBoxWeekParse.Controls.Add(TextBoxValueParsing);
            GroupBoxWeekParse.Controls.Add(ParsingValueLabel);
            GroupBoxWeekParse.Location = new Point(3, 3);
            GroupBoxWeekParse.Name = "GroupBoxWeekParse";
            GroupBoxWeekParse.Size = new Size(386, 153);
            GroupBoxWeekParse.TabIndex = 1;
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
            // WeekdayParsingEnumControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupBoxWeekParse);
            Name = "WeekdayParsingEnumControl";
            Size = new Size(397, 162);
            Load += WeekdayParsingEnumControl_Load;
            GroupBoxWeekParse.ResumeLayout(false);
            GroupBoxWeekParse.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxWeekParse;
        private Button ParseButton;
        private Label ResultLabel;
        private TextBox TextBoxValueParsing;
        private Label ParsingValueLabel;
    }
}
