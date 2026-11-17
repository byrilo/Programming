namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            _priorityRootTableLayoutPanel = new TableLayoutPanel();
            _priorityTopTableLayoutPanel = new TableLayoutPanel();
            _selectedOrderLabel = new Label();
            _orderIdLabel = new Label();
            _orderIdTextBox = new TextBox();
            _orderCreatedLabel = new Label();
            _orderCreatedTextBox = new TextBox();
            _orderStatusLabel = new Label();
            _orderStatusComboBox = new ComboBox();
            _priorityOptionsLabel = new Label();
            _deliveryTimeLabel = new Label();
            _deliveryTimeComboBox = new ComboBox();
            _orderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            _orderItemsLabel = new Label();
            _orderItemsListBox = new ListBox();
            _orderAmountLabel = new Label();
            _orderAmountValueLabel = new Label();
            _priorityButtonsTableLayoutPanel = new TableLayoutPanel();
            _addItemButton = new Button();
            _removeItemButton = new Button();
            _clearOrderButton = new Button();
            _priorityRootTableLayoutPanel.SuspendLayout();
            _priorityTopTableLayoutPanel.SuspendLayout();
            _priorityButtonsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            //
            // _priorityRootTableLayoutPanel
            //
            _priorityRootTableLayoutPanel.ColumnCount = 1;
            _priorityRootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _priorityRootTableLayoutPanel.Controls.Add(_priorityTopTableLayoutPanel, 0, 0);
            _priorityRootTableLayoutPanel.Controls.Add(_orderAddressControl, 0, 1);
            _priorityRootTableLayoutPanel.Controls.Add(_orderItemsLabel, 0, 2);
            _priorityRootTableLayoutPanel.Controls.Add(_orderItemsListBox, 0, 3);
            _priorityRootTableLayoutPanel.Controls.Add(_orderAmountLabel, 0, 4);
            _priorityRootTableLayoutPanel.Controls.Add(_orderAmountValueLabel, 0, 5);
            _priorityRootTableLayoutPanel.Controls.Add(_priorityButtonsTableLayoutPanel, 0, 6);
            _priorityRootTableLayoutPanel.Dock = DockStyle.Left;
            _priorityRootTableLayoutPanel.Location = new Point(0, 0);
            _priorityRootTableLayoutPanel.Name = "_priorityRootTableLayoutPanel";
            _priorityRootTableLayoutPanel.Padding = new Padding(12);
            _priorityRootTableLayoutPanel.RowCount = 7;
            _priorityRootTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityRootTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityRootTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityRootTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _priorityRootTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityRootTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityRootTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityRootTableLayoutPanel.Size = new Size(600, 717);
            _priorityRootTableLayoutPanel.TabIndex = 0;
            //
            // _priorityTopTableLayoutPanel
            //
            _priorityTopTableLayoutPanel.AutoSize = true;
            _priorityTopTableLayoutPanel.ColumnCount = 5;
            _priorityTopTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _priorityTopTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _priorityTopTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            _priorityTopTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _priorityTopTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _priorityTopTableLayoutPanel.Controls.Add(_selectedOrderLabel, 0, 0);
            _priorityTopTableLayoutPanel.SetColumnSpan(_selectedOrderLabel, 2);
            _priorityTopTableLayoutPanel.Controls.Add(_orderIdLabel, 0, 1);
            _priorityTopTableLayoutPanel.Controls.Add(_orderIdTextBox, 1, 1);
            _priorityTopTableLayoutPanel.Controls.Add(_orderCreatedLabel, 0, 2);
            _priorityTopTableLayoutPanel.Controls.Add(_orderCreatedTextBox, 1, 2);
            _priorityTopTableLayoutPanel.Controls.Add(_orderStatusLabel, 0, 3);
            _priorityTopTableLayoutPanel.Controls.Add(_orderStatusComboBox, 1, 3);
            _priorityTopTableLayoutPanel.Controls.Add(_priorityOptionsLabel, 3, 0);
            _priorityTopTableLayoutPanel.SetColumnSpan(_priorityOptionsLabel, 2);
            _priorityTopTableLayoutPanel.Controls.Add(_deliveryTimeLabel, 3, 1);
            _priorityTopTableLayoutPanel.Controls.Add(_deliveryTimeComboBox, 4, 1);
            _priorityTopTableLayoutPanel.Dock = DockStyle.Fill;
            _priorityTopTableLayoutPanel.Location = new Point(15, 15);
            _priorityTopTableLayoutPanel.Name = "_priorityTopTableLayoutPanel";
            _priorityTopTableLayoutPanel.RowCount = 4;
            _priorityTopTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityTopTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityTopTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityTopTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityTopTableLayoutPanel.Size = new Size(570, 128);
            _priorityTopTableLayoutPanel.TabIndex = 0;
            //
            // _selectedOrderLabel
            //
            _selectedOrderLabel.Anchor = AnchorStyles.Left;
            _selectedOrderLabel.AutoSize = true;
            _selectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _selectedOrderLabel.Margin = new Padding(3, 0, 3, 6);
            _selectedOrderLabel.Name = "_selectedOrderLabel";
            _selectedOrderLabel.Size = new Size(106, 20);
            _selectedOrderLabel.TabIndex = 0;
            _selectedOrderLabel.Text = "Selected Order";
            //
            // _orderIdLabel
            //
            _orderIdLabel.Anchor = AnchorStyles.Left;
            _orderIdLabel.AutoSize = true;
            _orderIdLabel.Margin = new Padding(3, 0, 12, 0);
            _orderIdLabel.Name = "_orderIdLabel";
            _orderIdLabel.Size = new Size(27, 20);
            _orderIdLabel.TabIndex = 1;
            _orderIdLabel.Text = "ID:";
            //
            // _orderIdTextBox
            //
            _orderIdTextBox.Anchor = AnchorStyles.Left;
            _orderIdTextBox.Name = "_orderIdTextBox";
            _orderIdTextBox.ReadOnly = true;
            _orderIdTextBox.Size = new Size(190, 27);
            _orderIdTextBox.TabIndex = 2;
            //
            // _orderCreatedLabel
            //
            _orderCreatedLabel.Anchor = AnchorStyles.Left;
            _orderCreatedLabel.AutoSize = true;
            _orderCreatedLabel.Margin = new Padding(3, 0, 12, 0);
            _orderCreatedLabel.Name = "_orderCreatedLabel";
            _orderCreatedLabel.Size = new Size(67, 20);
            _orderCreatedLabel.TabIndex = 3;
            _orderCreatedLabel.Text = "Created:";
            //
            // _orderCreatedTextBox
            //
            _orderCreatedTextBox.Anchor = AnchorStyles.Left;
            _orderCreatedTextBox.Name = "_orderCreatedTextBox";
            _orderCreatedTextBox.ReadOnly = true;
            _orderCreatedTextBox.Size = new Size(190, 27);
            _orderCreatedTextBox.TabIndex = 4;
            //
            // _orderStatusLabel
            //
            _orderStatusLabel.Anchor = AnchorStyles.Left;
            _orderStatusLabel.AutoSize = true;
            _orderStatusLabel.Margin = new Padding(3, 0, 12, 0);
            _orderStatusLabel.Name = "_orderStatusLabel";
            _orderStatusLabel.Size = new Size(56, 20);
            _orderStatusLabel.TabIndex = 5;
            _orderStatusLabel.Text = "Status:";
            //
            // _orderStatusComboBox
            //
            _orderStatusComboBox.Anchor = AnchorStyles.Left;
            _orderStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _orderStatusComboBox.FormattingEnabled = true;
            _orderStatusComboBox.Name = "_orderStatusComboBox";
            _orderStatusComboBox.Size = new Size(190, 28);
            _orderStatusComboBox.TabIndex = 6;
            _orderStatusComboBox.SelectedIndexChanged += _orderStatusComboBox_SelectedIndexChanged;
            //
            // _priorityOptionsLabel
            //
            _priorityOptionsLabel.Anchor = AnchorStyles.Left;
            _priorityOptionsLabel.AutoSize = true;
            _priorityOptionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _priorityOptionsLabel.Margin = new Padding(3, 0, 3, 6);
            _priorityOptionsLabel.Name = "_priorityOptionsLabel";
            _priorityOptionsLabel.Size = new Size(110, 20);
            _priorityOptionsLabel.TabIndex = 7;
            _priorityOptionsLabel.Text = "Priority Options";
            //
            // _deliveryTimeLabel
            //
            _deliveryTimeLabel.Anchor = AnchorStyles.Left;
            _deliveryTimeLabel.AutoSize = true;
            _deliveryTimeLabel.Margin = new Padding(3, 0, 12, 0);
            _deliveryTimeLabel.Name = "_deliveryTimeLabel";
            _deliveryTimeLabel.Size = new Size(103, 20);
            _deliveryTimeLabel.TabIndex = 8;
            _deliveryTimeLabel.Text = "Delivery Time:";
            //
            // _deliveryTimeComboBox
            //
            _deliveryTimeComboBox.Anchor = AnchorStyles.Left;
            _deliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _deliveryTimeComboBox.FormattingEnabled = true;
            _deliveryTimeComboBox.Name = "_deliveryTimeComboBox";
            _deliveryTimeComboBox.Size = new Size(150, 28);
            _deliveryTimeComboBox.TabIndex = 9;
            _deliveryTimeComboBox.SelectedIndexChanged += _deliveryTimeComboBox_SelectedIndexChanged;
            //
            // _orderAddressControl
            //
            _orderAddressControl.Anchor = AnchorStyles.Left;
            _orderAddressControl.Name = "_orderAddressControl";
            _orderAddressControl.Size = new Size(550, 261);
            _orderAddressControl.TabIndex = 1;
            //
            // _orderItemsLabel
            //
            _orderItemsLabel.Anchor = AnchorStyles.Left;
            _orderItemsLabel.AutoSize = true;
            _orderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _orderItemsLabel.Margin = new Padding(3, 6, 3, 6);
            _orderItemsLabel.Name = "_orderItemsLabel";
            _orderItemsLabel.Size = new Size(90, 20);
            _orderItemsLabel.TabIndex = 2;
            _orderItemsLabel.Text = "Order Items";
            //
            // _orderItemsListBox
            //
            _orderItemsListBox.Dock = DockStyle.Fill;
            _orderItemsListBox.FormattingEnabled = true;
            _orderItemsListBox.Name = "_orderItemsListBox";
            _orderItemsListBox.Size = new Size(570, 100);
            _orderItemsListBox.TabIndex = 3;
            //
            // _orderAmountLabel
            //
            _orderAmountLabel.Anchor = AnchorStyles.Right;
            _orderAmountLabel.AutoSize = true;
            _orderAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _orderAmountLabel.Margin = new Padding(3, 6, 3, 0);
            _orderAmountLabel.Name = "_orderAmountLabel";
            _orderAmountLabel.Size = new Size(68, 20);
            _orderAmountLabel.TabIndex = 4;
            _orderAmountLabel.Text = "Amount:";
            //
            // _orderAmountValueLabel
            //
            _orderAmountValueLabel.Anchor = AnchorStyles.Right;
            _orderAmountValueLabel.AutoSize = true;
            _orderAmountValueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _orderAmountValueLabel.Margin = new Padding(3, 0, 3, 6);
            _orderAmountValueLabel.Name = "_orderAmountValueLabel";
            _orderAmountValueLabel.Size = new Size(26, 37);
            _orderAmountValueLabel.TabIndex = 5;
            _orderAmountValueLabel.Text = "0";
            _orderAmountValueLabel.TextAlign = ContentAlignment.MiddleRight;
            //
            // _priorityButtonsTableLayoutPanel
            //
            _priorityButtonsTableLayoutPanel.AutoSize = true;
            _priorityButtonsTableLayoutPanel.ColumnCount = 4;
            _priorityButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _priorityButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _priorityButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _priorityButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _priorityButtonsTableLayoutPanel.Controls.Add(_addItemButton, 0, 0);
            _priorityButtonsTableLayoutPanel.Controls.Add(_removeItemButton, 1, 0);
            _priorityButtonsTableLayoutPanel.Controls.Add(_clearOrderButton, 3, 0);
            _priorityButtonsTableLayoutPanel.Dock = DockStyle.Fill;
            _priorityButtonsTableLayoutPanel.Name = "_priorityButtonsTableLayoutPanel";
            _priorityButtonsTableLayoutPanel.RowCount = 1;
            _priorityButtonsTableLayoutPanel.RowStyles.Add(new RowStyle());
            _priorityButtonsTableLayoutPanel.Size = new Size(570, 40);
            _priorityButtonsTableLayoutPanel.TabIndex = 6;
            //
            // _addItemButton
            //
            _addItemButton.Name = "_addItemButton";
            _addItemButton.Size = new Size(110, 34);
            _addItemButton.TabIndex = 0;
            _addItemButton.Text = "Add Item";
            _addItemButton.UseVisualStyleBackColor = true;
            _addItemButton.Click += _addItemButton_Click;
            //
            // _removeItemButton
            //
            _removeItemButton.Name = "_removeItemButton";
            _removeItemButton.Size = new Size(110, 34);
            _removeItemButton.TabIndex = 1;
            _removeItemButton.Text = "Remove Item";
            _removeItemButton.UseVisualStyleBackColor = true;
            _removeItemButton.Click += _removeItemButton_Click;
            //
            // _clearOrderButton
            //
            _clearOrderButton.Name = "_clearOrderButton";
            _clearOrderButton.Size = new Size(110, 34);
            _clearOrderButton.TabIndex = 2;
            _clearOrderButton.Text = "Clear Order";
            _clearOrderButton.UseVisualStyleBackColor = true;
            _clearOrderButton.Click += _clearOrderButton_Click;
            //
            // PriorityOrdersTab
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_priorityRootTableLayoutPanel);
            Name = "PriorityOrdersTab";
            Size = new Size(1098, 717);
            _priorityRootTableLayoutPanel.ResumeLayout(false);
            _priorityRootTableLayoutPanel.PerformLayout();
            _priorityTopTableLayoutPanel.ResumeLayout(false);
            _priorityTopTableLayoutPanel.PerformLayout();
            _priorityButtonsTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel _priorityRootTableLayoutPanel;
        private TableLayoutPanel _priorityTopTableLayoutPanel;
        private Label _selectedOrderLabel;
        private Label _orderIdLabel;
        private TextBox _orderIdTextBox;
        private Label _orderCreatedLabel;
        private TextBox _orderCreatedTextBox;
        private Label _orderStatusLabel;
        private ComboBox _orderStatusComboBox;
        private Label _priorityOptionsLabel;
        private Label _deliveryTimeLabel;
        private ComboBox _deliveryTimeComboBox;
        private ObjectOrientedPractics.View.Controls.AddressControl _orderAddressControl;
        private Label _orderItemsLabel;
        private ListBox _orderItemsListBox;
        private Label _orderAmountLabel;
        private Label _orderAmountValueLabel;
        private TableLayoutPanel _priorityButtonsTableLayoutPanel;
        private Button _addItemButton;
        private Button _removeItemButton;
        private Button _clearOrderButton;
    }
}
