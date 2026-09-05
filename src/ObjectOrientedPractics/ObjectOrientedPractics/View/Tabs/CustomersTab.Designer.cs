namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            _customersLabel = new Label();
            _customersListBox = new ListBox();
            _customersAddButton = new Button();
            _customersRemoveButton = new Button();
            _customersGroupBox = new GroupBox();
            _customersPanel = new Panel();
            _customersIdTextBox = new TextBox();
            _customersFullNameTextBox = new TextBox();
            _customersAdressTextBox = new TextBox();
            _customersIdLabel = new Label();
            _customersFullNameLabel = new Label();
            _customersAddressLabel = new Label();
            _customersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // _customersLabel
            // 
            _customersLabel.AutoSize = true;
            _customersLabel.Location = new Point(3, 10);
            _customersLabel.Name = "_customersLabel";
            _customersLabel.Size = new Size(78, 20);
            _customersLabel.TabIndex = 0;
            _customersLabel.Text = "Customers";
            // 
            // _customersListBox
            // 
            _customersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            _customersListBox.FormattingEnabled = true;
            _customersListBox.Location = new Point(3, 43);
            _customersListBox.Name = "_customersListBox";
            _customersListBox.Size = new Size(350, 464);
            _customersListBox.TabIndex = 1;
            // 
            // _customersAddButton
            // 
            _customersAddButton.Location = new Point(3, 526);
            _customersAddButton.Name = "_customersAddButton";
            _customersAddButton.Size = new Size(114, 59);
            _customersAddButton.TabIndex = 2;
            _customersAddButton.Text = "Add";
            _customersAddButton.UseVisualStyleBackColor = true;
            // 
            // _customersRemoveButton
            // 
            _customersRemoveButton.Location = new Point(123, 526);
            _customersRemoveButton.Name = "_customersRemoveButton";
            _customersRemoveButton.Size = new Size(114, 59);
            _customersRemoveButton.TabIndex = 3;
            _customersRemoveButton.Text = "Remove";
            _customersRemoveButton.UseVisualStyleBackColor = true;
            // 
            // _customersGroupBox
            // 
            _customersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _customersGroupBox.Controls.Add(_customersAddressLabel);
            _customersGroupBox.Controls.Add(_customersFullNameLabel);
            _customersGroupBox.Controls.Add(_customersIdLabel);
            _customersGroupBox.Controls.Add(_customersIdTextBox);
            _customersGroupBox.Controls.Add(_customersFullNameTextBox);
            _customersGroupBox.Controls.Add(_customersAdressTextBox);
            _customersGroupBox.Controls.Add(_customersPanel);
            _customersGroupBox.Location = new Point(359, 10);
            _customersGroupBox.Name = "_customersGroupBox";
            _customersGroupBox.Size = new Size(494, 575);
            _customersGroupBox.TabIndex = 4;
            _customersGroupBox.TabStop = false;
            _customersGroupBox.Text = "Selected customer";
            // 
            // _customersPanel
            // 
            _customersPanel.Location = new Point(6, 281);
            _customersPanel.Name = "_customersPanel";
            _customersPanel.Size = new Size(482, 288);
            _customersPanel.TabIndex = 5;
            // 
            // _customersIdTextBox
            // 
            _customersIdTextBox.Location = new Point(87, 26);
            _customersIdTextBox.Name = "_customersIdTextBox";
            _customersIdTextBox.Size = new Size(125, 27);
            _customersIdTextBox.TabIndex = 5;
            // 
            // _customersFullNameTextBox
            // 
            _customersFullNameTextBox.Location = new Point(87, 75);
            _customersFullNameTextBox.Name = "_customersFullNameTextBox";
            _customersFullNameTextBox.Size = new Size(401, 27);
            _customersFullNameTextBox.TabIndex = 6;
            // 
            // _customersAdressTextBox
            // 
            _customersAdressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _customersAdressTextBox.Location = new Point(87, 132);
            _customersAdressTextBox.Multiline = true;
            _customersAdressTextBox.Name = "_customersAdressTextBox";
            _customersAdressTextBox.Size = new Size(401, 130);
            _customersAdressTextBox.TabIndex = 7;
            // 
            // _customersIdLabel
            // 
            _customersIdLabel.AutoSize = true;
            _customersIdLabel.Location = new Point(6, 33);
            _customersIdLabel.Name = "_customersIdLabel";
            _customersIdLabel.Size = new Size(27, 20);
            _customersIdLabel.TabIndex = 8;
            _customersIdLabel.Text = "ID:";
            // 
            // _customersFullNameLabel
            // 
            _customersFullNameLabel.AutoSize = true;
            _customersFullNameLabel.Location = new Point(6, 78);
            _customersFullNameLabel.Name = "_customersFullNameLabel";
            _customersFullNameLabel.Size = new Size(79, 20);
            _customersFullNameLabel.TabIndex = 9;
            _customersFullNameLabel.Text = "Full Name:";
            // 
            // _customersAddressLabel
            // 
            _customersAddressLabel.AutoSize = true;
            _customersAddressLabel.Location = new Point(6, 132);
            _customersAddressLabel.Name = "_customersAddressLabel";
            _customersAddressLabel.Size = new Size(62, 20);
            _customersAddressLabel.TabIndex = 10;
            _customersAddressLabel.Text = "Address";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_customersGroupBox);
            Controls.Add(_customersRemoveButton);
            Controls.Add(_customersAddButton);
            Controls.Add(_customersListBox);
            Controls.Add(_customersLabel);
            Name = "CustomersTab";
            Size = new Size(856, 597);
            _customersGroupBox.ResumeLayout(false);
            _customersGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _customersLabel;
        private ListBox _customersListBox;
        private Button _customersAddButton;
        private Button _customersRemoveButton;
        private GroupBox _customersGroupBox;
        private Label _customersAddressLabel;
        private Label _customersFullNameLabel;
        private Label _customersIdLabel;
        private TextBox _customersIdTextBox;
        private TextBox _customersFullNameTextBox;
        private TextBox _customersAdressTextBox;
        private Panel _customersPanel;
    }
}
