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
            _customersRootTableLayoutPanel = new TableLayoutPanel();
            _customersLeftTableLayoutPanel = new TableLayoutPanel();
            _customersLabel = new Label();
            _customersListBox = new ListBox();
            _customersButtonsFlowPanel = new FlowLayoutPanel();
            _customersAddButton = new Button();
            _customersRemoveButton = new Button();
            _customersRandomButton = new Button();
            _customersGroupBox = new GroupBox();
            _customersAddressLabel = new Label();
            _customersFullNameLabel = new Label();
            _customersIdLabel = new Label();
            _customersIdTextBox = new TextBox();
            _customersFullNameTextBox = new TextBox();
            _customersAddressTextBox = new TextBox();
            _customersPanel = new Panel();
            _customersRootTableLayoutPanel.SuspendLayout();
            _customersLeftTableLayoutPanel.SuspendLayout();
            _customersButtonsFlowPanel.SuspendLayout();
            _customersGroupBox.SuspendLayout();
            SuspendLayout();
            //
            // _customersRootTableLayoutPanel
            //
            _customersRootTableLayoutPanel.ColumnCount = 2;
            _customersRootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            _customersRootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            _customersRootTableLayoutPanel.Controls.Add(_customersLeftTableLayoutPanel, 0, 0);
            _customersRootTableLayoutPanel.Controls.Add(_customersGroupBox, 1, 0);
            _customersRootTableLayoutPanel.Dock = DockStyle.Fill;
            _customersRootTableLayoutPanel.Location = new Point(0, 0);
            _customersRootTableLayoutPanel.Name = "_customersRootTableLayoutPanel";
            _customersRootTableLayoutPanel.Padding = new Padding(12);
            _customersRootTableLayoutPanel.RowCount = 1;
            _customersRootTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _customersRootTableLayoutPanel.Size = new Size(856, 597);
            _customersRootTableLayoutPanel.TabIndex = 0;
            //
            // _customersLeftTableLayoutPanel
            //
            _customersLeftTableLayoutPanel.ColumnCount = 1;
            _customersLeftTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _customersLeftTableLayoutPanel.Controls.Add(_customersLabel, 0, 0);
            _customersLeftTableLayoutPanel.Controls.Add(_customersListBox, 0, 1);
            _customersLeftTableLayoutPanel.Controls.Add(_customersButtonsFlowPanel, 0, 2);
            _customersLeftTableLayoutPanel.Dock = DockStyle.Fill;
            _customersLeftTableLayoutPanel.Location = new Point(15, 15);
            _customersLeftTableLayoutPanel.Margin = new Padding(3, 3, 12, 3);
            _customersLeftTableLayoutPanel.Name = "_customersLeftTableLayoutPanel";
            _customersLeftTableLayoutPanel.RowCount = 3;
            _customersLeftTableLayoutPanel.RowStyles.Add(new RowStyle());
            _customersLeftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _customersLeftTableLayoutPanel.RowStyles.Add(new RowStyle());
            _customersLeftTableLayoutPanel.Size = new Size(316, 567);
            _customersLeftTableLayoutPanel.TabIndex = 0;
            //
            // _customersLabel
            //
            _customersLabel.AutoSize = true;
            _customersLabel.Location = new Point(3, 0);
            _customersLabel.Margin = new Padding(3, 0, 3, 6);
            _customersLabel.Name = "_customersLabel";
            _customersLabel.Size = new Size(78, 20);
            _customersLabel.TabIndex = 0;
            _customersLabel.Text = "Customers";
            //
            // _customersListBox
            //
            _customersListBox.Dock = DockStyle.Fill;
            _customersListBox.FormattingEnabled = true;
            _customersListBox.Location = new Point(3, 29);
            _customersListBox.Margin = new Padding(3, 3, 3, 6);
            _customersListBox.Name = "_customersListBox";
            _customersListBox.Size = new Size(310, 473);
            _customersListBox.TabIndex = 1;
            _customersListBox.SelectedIndexChanged += _customersListBox_SelectedIndexChanged;
            //
            // _customersButtonsFlowPanel
            //
            _customersButtonsFlowPanel.AutoSize = true;
            _customersButtonsFlowPanel.Controls.Add(_customersAddButton);
            _customersButtonsFlowPanel.Controls.Add(_customersRemoveButton);
            _customersButtonsFlowPanel.Controls.Add(_customersRandomButton);
            _customersButtonsFlowPanel.Dock = DockStyle.Fill;
            _customersButtonsFlowPanel.FlowDirection = FlowDirection.LeftToRight;
            _customersButtonsFlowPanel.Location = new Point(3, 514);
            _customersButtonsFlowPanel.Margin = new Padding(3, 6, 3, 3);
            _customersButtonsFlowPanel.Name = "_customersButtonsFlowPanel";
            _customersButtonsFlowPanel.Size = new Size(310, 50);
            _customersButtonsFlowPanel.TabIndex = 2;
            //
            // _customersAddButton
            //
            _customersAddButton.Location = new Point(3, 3);
            _customersAddButton.Name = "_customersAddButton";
            _customersAddButton.Size = new Size(96, 44);
            _customersAddButton.TabIndex = 0;
            _customersAddButton.Text = "Add";
            _customersAddButton.UseVisualStyleBackColor = true;
            _customersAddButton.Click += _customersAddButton_Click;
            //
            // _customersRemoveButton
            //
            _customersRemoveButton.Location = new Point(105, 3);
            _customersRemoveButton.Name = "_customersRemoveButton";
            _customersRemoveButton.Size = new Size(96, 44);
            _customersRemoveButton.TabIndex = 1;
            _customersRemoveButton.Text = "Remove";
            _customersRemoveButton.UseVisualStyleBackColor = true;
            _customersRemoveButton.Click += _customersRemoveButton_Click;
            //
            // _customersRandomButton
            //
            _customersRandomButton.Location = new Point(207, 3);
            _customersRandomButton.Name = "_customersRandomButton";
            _customersRandomButton.Size = new Size(96, 44);
            _customersRandomButton.TabIndex = 2;
            _customersRandomButton.Text = "Random";
            _customersRandomButton.UseVisualStyleBackColor = true;
            _customersRandomButton.Click += _customersRandomButton_Click;
            //
            // _customersGroupBox
            //
            _customersGroupBox.Controls.Add(_customersAddressLabel);
            _customersGroupBox.Controls.Add(_customersFullNameLabel);
            _customersGroupBox.Controls.Add(_customersIdLabel);
            _customersGroupBox.Controls.Add(_customersIdTextBox);
            _customersGroupBox.Controls.Add(_customersFullNameTextBox);
            _customersGroupBox.Controls.Add(_customersAddressTextBox);
            _customersGroupBox.Controls.Add(_customersPanel);
            _customersGroupBox.Dock = DockStyle.Fill;
            _customersGroupBox.Location = new Point(343, 15);
            _customersGroupBox.Margin = new Padding(12, 3, 3, 3);
            _customersGroupBox.Name = "_customersGroupBox";
            _customersGroupBox.Size = new Size(498, 567);
            _customersGroupBox.TabIndex = 1;
            _customersGroupBox.TabStop = false;
            _customersGroupBox.Text = "Selected customer";
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
            // _customersFullNameLabel
            //
            _customersFullNameLabel.AutoSize = true;
            _customersFullNameLabel.Location = new Point(6, 78);
            _customersFullNameLabel.Name = "_customersFullNameLabel";
            _customersFullNameLabel.Size = new Size(79, 20);
            _customersFullNameLabel.TabIndex = 9;
            _customersFullNameLabel.Text = "Full Name:";
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
            // _customersIdTextBox
            //
            _customersIdTextBox.Location = new Point(87, 26);
            _customersIdTextBox.Name = "_customersIdTextBox";
            _customersIdTextBox.ReadOnly = true;
            _customersIdTextBox.Size = new Size(125, 27);
            _customersIdTextBox.TabIndex = 5;
            //
            // _customersFullNameTextBox
            //
            _customersFullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _customersFullNameTextBox.Location = new Point(87, 75);
            _customersFullNameTextBox.Name = "_customersFullNameTextBox";
            _customersFullNameTextBox.Size = new Size(405, 27);
            _customersFullNameTextBox.TabIndex = 6;
            _customersFullNameTextBox.TextChanged += _customersFullNameTextBox_TextChanged;
            //
            // _customersAddressTextBox
            //
            _customersAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _customersAddressTextBox.Location = new Point(87, 132);
            _customersAddressTextBox.Multiline = true;
            _customersAddressTextBox.Name = "_customersAddressTextBox";
            _customersAddressTextBox.Size = new Size(405, 130);
            _customersAddressTextBox.TabIndex = 7;
            _customersAddressTextBox.TextChanged += _customersAddressTextBox_TextChanged;
            //
            // _customersPanel
            //
            _customersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _customersPanel.Location = new Point(6, 281);
            _customersPanel.Name = "_customersPanel";
            _customersPanel.Size = new Size(486, 280);
            _customersPanel.TabIndex = 5;
            //
            // CustomersTab
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_customersRootTableLayoutPanel);
            Name = "CustomersTab";
            Size = new Size(856, 597);
            _customersRootTableLayoutPanel.ResumeLayout(false);
            _customersLeftTableLayoutPanel.ResumeLayout(false);
            _customersLeftTableLayoutPanel.PerformLayout();
            _customersButtonsFlowPanel.ResumeLayout(false);
            _customersGroupBox.ResumeLayout(false);
            _customersGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel _customersRootTableLayoutPanel;
        private TableLayoutPanel _customersLeftTableLayoutPanel;
        private Label _customersLabel;
        private ListBox _customersListBox;
        private FlowLayoutPanel _customersButtonsFlowPanel;
        private Button _customersAddButton;
        private Button _customersRemoveButton;
        private Button _customersRandomButton;
        private GroupBox _customersGroupBox;
        private Label _customersAddressLabel;
        private Label _customersFullNameLabel;
        private Label _customersIdLabel;
        private TextBox _customersIdTextBox;
        private TextBox _customersFullNameTextBox;
        private TextBox _customersAddressTextBox;
        private Panel _customersPanel;
    }
}
