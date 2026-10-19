namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            DataGridViewCellStyle createdCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle amountCellStyle = new DataGridViewCellStyle();
            _ordersRootTableLayoutPanel = new TableLayoutPanel();
            _ordersLeftTableLayoutPanel = new TableLayoutPanel();
            _ordersLabel = new Label();
            _ordersDataGridView = new DataGridView();
            _idColumn = new DataGridViewTextBoxColumn();
            _createdColumn = new DataGridViewTextBoxColumn();
            _customerColumn = new DataGridViewTextBoxColumn();
            _addressColumn = new DataGridViewTextBoxColumn();
            _amountColumn = new DataGridViewTextBoxColumn();
            _statusColumn = new DataGridViewTextBoxColumn();
            _ordersRightTableLayoutPanel = new TableLayoutPanel();
            _selectedOrderLabel = new Label();
            _orderIdLabel = new Label();
            _orderIdTextBox = new TextBox();
            _orderCreatedLabel = new Label();
            _orderCreatedTextBox = new TextBox();
            _orderStatusLabel = new Label();
            _orderStatusComboBox = new ComboBox();
            _orderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            _orderItemsLabel = new Label();
            _orderItemsListBox = new ListBox();
            _orderAmountLabel = new Label();
            _orderAmountValueLabel = new Label();
            _ordersRootTableLayoutPanel.SuspendLayout();
            _ordersLeftTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_ordersDataGridView).BeginInit();
            _ordersRightTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            //
            // _ordersRootTableLayoutPanel
            //
            _ordersRootTableLayoutPanel.ColumnCount = 2;
            _ordersRootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _ordersRootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _ordersRootTableLayoutPanel.Controls.Add(_ordersLeftTableLayoutPanel, 0, 0);
            _ordersRootTableLayoutPanel.Controls.Add(_ordersRightTableLayoutPanel, 1, 0);
            _ordersRootTableLayoutPanel.Dock = DockStyle.Fill;
            _ordersRootTableLayoutPanel.Location = new Point(0, 0);
            _ordersRootTableLayoutPanel.Name = "_ordersRootTableLayoutPanel";
            _ordersRootTableLayoutPanel.Padding = new Padding(12);
            _ordersRootTableLayoutPanel.RowCount = 1;
            _ordersRootTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _ordersRootTableLayoutPanel.Size = new Size(1098, 717);
            _ordersRootTableLayoutPanel.TabIndex = 0;
            //
            // _ordersLeftTableLayoutPanel
            //
            _ordersLeftTableLayoutPanel.ColumnCount = 1;
            _ordersLeftTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _ordersLeftTableLayoutPanel.Controls.Add(_ordersLabel, 0, 0);
            _ordersLeftTableLayoutPanel.Controls.Add(_ordersDataGridView, 0, 1);
            _ordersLeftTableLayoutPanel.Dock = DockStyle.Fill;
            _ordersLeftTableLayoutPanel.Location = new Point(15, 15);
            _ordersLeftTableLayoutPanel.Margin = new Padding(3, 3, 12, 3);
            _ordersLeftTableLayoutPanel.Name = "_ordersLeftTableLayoutPanel";
            _ordersLeftTableLayoutPanel.RowCount = 2;
            _ordersLeftTableLayoutPanel.RowStyles.Add(new RowStyle());
            _ordersLeftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _ordersLeftTableLayoutPanel.Size = new Size(480, 687);
            _ordersLeftTableLayoutPanel.TabIndex = 0;
            //
            // _ordersLabel
            //
            _ordersLabel.Anchor = AnchorStyles.Left;
            _ordersLabel.AutoSize = true;
            _ordersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _ordersLabel.Margin = new Padding(3, 0, 3, 6);
            _ordersLabel.Name = "_ordersLabel";
            _ordersLabel.Size = new Size(55, 20);
            _ordersLabel.TabIndex = 0;
            _ordersLabel.Text = "Orders";
            //
            // _ordersDataGridView
            //
            _ordersDataGridView.AllowUserToAddRows = false;
            _ordersDataGridView.AllowUserToDeleteRows = false;
            _ordersDataGridView.AllowUserToOrderColumns = false;
            _ordersDataGridView.AllowUserToResizeRows = false;
            _ordersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _ordersDataGridView.Columns.AddRange(new DataGridViewColumn[] { _idColumn, _createdColumn, _customerColumn, _addressColumn, _amountColumn, _statusColumn });
            _ordersDataGridView.Dock = DockStyle.Fill;
            _ordersDataGridView.MultiSelect = false;
            _ordersDataGridView.Name = "_ordersDataGridView";
            _ordersDataGridView.ReadOnly = true;
            _ordersDataGridView.RowHeadersVisible = false;
            _ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _ordersDataGridView.Size = new Size(474, 655);
            _ordersDataGridView.TabIndex = 1;
            _ordersDataGridView.SelectionChanged += _ordersDataGridView_SelectionChanged;
            //
            // _idColumn
            //
            _idColumn.FillWeight = 8F;
            _idColumn.HeaderText = "Id";
            _idColumn.MinimumWidth = 40;
            _idColumn.Name = "_idColumn";
            _idColumn.ReadOnly = true;
            _idColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // _createdColumn
            //
            createdCellStyle.Format = "dd.MM.yy HH:mm";
            _createdColumn.DefaultCellStyle = createdCellStyle;
            _createdColumn.FillWeight = 40F;
            _createdColumn.HeaderText = "Created";
            _createdColumn.MinimumWidth = 80;
            _createdColumn.Name = "_createdColumn";
            _createdColumn.ReadOnly = true;
            _createdColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // _customerColumn
            //
            _customerColumn.FillWeight = 34F;
            _customerColumn.HeaderText = "Customer Full Name";
            _customerColumn.MinimumWidth = 80;
            _customerColumn.Name = "_customerColumn";
            _customerColumn.ReadOnly = true;
            _customerColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // _addressColumn
            //
            _addressColumn.FillWeight = 46F;
            _addressColumn.HeaderText = "Address";
            _addressColumn.MinimumWidth = 80;
            _addressColumn.Name = "_addressColumn";
            _addressColumn.ReadOnly = true;
            _addressColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // _amountColumn
            //
            amountCellStyle.Format = "N2";
            _amountColumn.DefaultCellStyle = amountCellStyle;
            _amountColumn.FillWeight = 26F;
            _amountColumn.HeaderText = "Amount";
            _amountColumn.MinimumWidth = 60;
            _amountColumn.Name = "_amountColumn";
            _amountColumn.ReadOnly = true;
            _amountColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // _statusColumn
            //
            _statusColumn.FillWeight = 22F;
            _statusColumn.HeaderText = "Order Status";
            _statusColumn.MinimumWidth = 80;
            _statusColumn.Name = "_statusColumn";
            _statusColumn.ReadOnly = true;
            _statusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            //
            // _ordersRightTableLayoutPanel
            //
            _ordersRightTableLayoutPanel.AutoSize = true;
            _ordersRightTableLayoutPanel.ColumnCount = 2;
            _ordersRightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _ordersRightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _ordersRightTableLayoutPanel.Controls.Add(_selectedOrderLabel, 0, 0);
            _ordersRightTableLayoutPanel.SetColumnSpan(_selectedOrderLabel, 2);
            _ordersRightTableLayoutPanel.Controls.Add(_orderIdLabel, 0, 1);
            _ordersRightTableLayoutPanel.Controls.Add(_orderIdTextBox, 1, 1);
            _ordersRightTableLayoutPanel.Controls.Add(_orderCreatedLabel, 0, 2);
            _ordersRightTableLayoutPanel.Controls.Add(_orderCreatedTextBox, 1, 2);
            _ordersRightTableLayoutPanel.Controls.Add(_orderStatusLabel, 0, 3);
            _ordersRightTableLayoutPanel.Controls.Add(_orderStatusComboBox, 1, 3);
            _ordersRightTableLayoutPanel.Controls.Add(_orderAddressControl, 0, 4);
            _ordersRightTableLayoutPanel.SetColumnSpan(_orderAddressControl, 2);
            _ordersRightTableLayoutPanel.Controls.Add(_orderItemsLabel, 0, 5);
            _ordersRightTableLayoutPanel.SetColumnSpan(_orderItemsLabel, 2);
            _ordersRightTableLayoutPanel.Controls.Add(_orderItemsListBox, 0, 6);
            _ordersRightTableLayoutPanel.SetColumnSpan(_orderItemsListBox, 2);
            _ordersRightTableLayoutPanel.Controls.Add(_orderAmountLabel, 0, 7);
            _ordersRightTableLayoutPanel.SetColumnSpan(_orderAmountLabel, 2);
            _ordersRightTableLayoutPanel.Controls.Add(_orderAmountValueLabel, 0, 8);
            _ordersRightTableLayoutPanel.SetColumnSpan(_orderAmountValueLabel, 2);
            _ordersRightTableLayoutPanel.Dock = DockStyle.Fill;
            _ordersRightTableLayoutPanel.Location = new Point(507, 15);
            _ordersRightTableLayoutPanel.Name = "_ordersRightTableLayoutPanel";
            _ordersRightTableLayoutPanel.RowCount = 9;
            _ordersRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _ordersRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _ordersRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _ordersRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _ordersRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _ordersRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _ordersRightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _ordersRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _ordersRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _ordersRightTableLayoutPanel.Size = new Size(576, 687);
            _ordersRightTableLayoutPanel.TabIndex = 1;
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
            // _orderAddressControl
            //
            _orderAddressControl.Anchor = AnchorStyles.Left;
            _orderAddressControl.Name = "_orderAddressControl";
            _orderAddressControl.Size = new Size(550, 261);
            _orderAddressControl.TabIndex = 7;
            //
            // _orderItemsLabel
            //
            _orderItemsLabel.Anchor = AnchorStyles.Left;
            _orderItemsLabel.AutoSize = true;
            _orderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _orderItemsLabel.Margin = new Padding(3, 6, 3, 6);
            _orderItemsLabel.Name = "_orderItemsLabel";
            _orderItemsLabel.Size = new Size(90, 20);
            _orderItemsLabel.TabIndex = 9;
            _orderItemsLabel.Text = "Order Items";
            //
            // _orderItemsListBox
            //
            _orderItemsListBox.Dock = DockStyle.Fill;
            _orderItemsListBox.FormattingEnabled = true;
            _orderItemsListBox.Name = "_orderItemsListBox";
            _orderItemsListBox.Size = new Size(570, 100);
            _orderItemsListBox.TabIndex = 10;
            //
            // _orderAmountLabel
            //
            _orderAmountLabel.Anchor = AnchorStyles.Right;
            _orderAmountLabel.AutoSize = true;
            _orderAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _orderAmountLabel.Margin = new Padding(3, 6, 3, 0);
            _orderAmountLabel.Name = "_orderAmountLabel";
            _orderAmountLabel.Size = new Size(68, 20);
            _orderAmountLabel.TabIndex = 11;
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
            _orderAmountValueLabel.TabIndex = 12;
            _orderAmountValueLabel.Text = "0";
            _orderAmountValueLabel.TextAlign = ContentAlignment.MiddleRight;
            //
            // OrdersTab
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_ordersRootTableLayoutPanel);
            Name = "OrdersTab";
            Size = new Size(1098, 717);
            _ordersRootTableLayoutPanel.ResumeLayout(false);
            _ordersRootTableLayoutPanel.PerformLayout();
            _ordersLeftTableLayoutPanel.ResumeLayout(false);
            _ordersLeftTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_ordersDataGridView).EndInit();
            _ordersRightTableLayoutPanel.ResumeLayout(false);
            _ordersRightTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel _ordersRootTableLayoutPanel;
        private TableLayoutPanel _ordersLeftTableLayoutPanel;
        private Label _ordersLabel;
        private DataGridView _ordersDataGridView;
        private DataGridViewTextBoxColumn _idColumn;
        private DataGridViewTextBoxColumn _createdColumn;
        private DataGridViewTextBoxColumn _customerColumn;
        private DataGridViewTextBoxColumn _addressColumn;
        private DataGridViewTextBoxColumn _amountColumn;
        private DataGridViewTextBoxColumn _statusColumn;
        private TableLayoutPanel _ordersRightTableLayoutPanel;
        private Label _selectedOrderLabel;
        private Label _orderIdLabel;
        private TextBox _orderIdTextBox;
        private Label _orderCreatedLabel;
        private TextBox _orderCreatedTextBox;
        private Label _orderStatusLabel;
        private ComboBox _orderStatusComboBox;
        private ObjectOrientedPractics.View.Controls.AddressControl _orderAddressControl;
        private Label _orderItemsLabel;
        private ListBox _orderItemsListBox;
        private Label _orderAmountLabel;
        private Label _orderAmountValueLabel;
    }
}
