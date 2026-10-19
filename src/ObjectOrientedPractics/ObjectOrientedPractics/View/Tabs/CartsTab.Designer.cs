namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            _cartsRootTableLayoutPanel = new TableLayoutPanel();
            _cartsLeftTableLayoutPanel = new TableLayoutPanel();
            _itemsLabel = new Label();
            _itemsListBox = new ListBox();
            _addToCartButton = new Button();
            _cartsRightTableLayoutPanel = new TableLayoutPanel();
            _customerLabel = new Label();
            _customerComboBox = new ComboBox();
            _cartLabel = new Label();
            _cartListBox = new ListBox();
            _amountLabel = new Label();
            _amountValueLabel = new Label();
            _cartsButtonsTableLayoutPanel = new TableLayoutPanel();
            _createOrderButton = new Button();
            _removeItemButton = new Button();
            _clearCartButton = new Button();
            _cartsRootTableLayoutPanel.SuspendLayout();
            _cartsLeftTableLayoutPanel.SuspendLayout();
            _cartsRightTableLayoutPanel.SuspendLayout();
            _cartsButtonsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // _cartsRootTableLayoutPanel
            // 
            _cartsRootTableLayoutPanel.ColumnCount = 2;
            _cartsRootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            _cartsRootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            _cartsRootTableLayoutPanel.Controls.Add(_cartsLeftTableLayoutPanel, 0, 0);
            _cartsRootTableLayoutPanel.Controls.Add(_cartsRightTableLayoutPanel, 1, 0);
            _cartsRootTableLayoutPanel.Dock = DockStyle.Fill;
            _cartsRootTableLayoutPanel.Location = new Point(0, 0);
            _cartsRootTableLayoutPanel.Name = "_cartsRootTableLayoutPanel";
            _cartsRootTableLayoutPanel.Padding = new Padding(12);
            _cartsRootTableLayoutPanel.RowCount = 1;
            _cartsRootTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _cartsRootTableLayoutPanel.Size = new Size(1098, 717);
            _cartsRootTableLayoutPanel.TabIndex = 0;
            // 
            // _cartsLeftTableLayoutPanel
            // 
            _cartsLeftTableLayoutPanel.ColumnCount = 1;
            _cartsLeftTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _cartsLeftTableLayoutPanel.Controls.Add(_itemsLabel, 0, 0);
            _cartsLeftTableLayoutPanel.Controls.Add(_itemsListBox, 0, 1);
            _cartsLeftTableLayoutPanel.Controls.Add(_addToCartButton, 0, 2);
            _cartsLeftTableLayoutPanel.Dock = DockStyle.Fill;
            _cartsLeftTableLayoutPanel.Location = new Point(15, 15);
            _cartsLeftTableLayoutPanel.Margin = new Padding(3, 3, 12, 3);
            _cartsLeftTableLayoutPanel.Name = "_cartsLeftTableLayoutPanel";
            _cartsLeftTableLayoutPanel.RowCount = 3;
            _cartsLeftTableLayoutPanel.RowStyles.Add(new RowStyle());
            _cartsLeftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _cartsLeftTableLayoutPanel.RowStyles.Add(new RowStyle());
            _cartsLeftTableLayoutPanel.Size = new Size(414, 687);
            _cartsLeftTableLayoutPanel.TabIndex = 0;
            // 
            // _itemsLabel
            // 
            _itemsLabel.Anchor = AnchorStyles.Left;
            _itemsLabel.AutoSize = true;
            _itemsLabel.Location = new Point(3, 0);
            _itemsLabel.Margin = new Padding(3, 0, 3, 6);
            _itemsLabel.Name = "_itemsLabel";
            _itemsLabel.Size = new Size(45, 20);
            _itemsLabel.TabIndex = 0;
            _itemsLabel.Text = "Items";
            // 
            // _itemsListBox
            // 
            _itemsListBox.Dock = DockStyle.Fill;
            _itemsListBox.FormattingEnabled = true;
            _itemsListBox.Location = new Point(3, 29);
            _itemsListBox.Margin = new Padding(3, 3, 3, 6);
            _itemsListBox.Name = "_itemsListBox";
            _itemsListBox.Size = new Size(408, 599);
            _itemsListBox.TabIndex = 1;
            // 
            // _addToCartButton
            // 
            _addToCartButton.Anchor = AnchorStyles.Left;
            _addToCartButton.Location = new Point(3, 640);
            _addToCartButton.Margin = new Padding(3, 6, 3, 3);
            _addToCartButton.Name = "_addToCartButton";
            _addToCartButton.Size = new Size(140, 44);
            _addToCartButton.TabIndex = 2;
            _addToCartButton.Text = "Add To Cart";
            _addToCartButton.UseVisualStyleBackColor = true;
            _addToCartButton.Click += _addToCartButton_Click;
            // 
            // _cartsRightTableLayoutPanel
            // 
            _cartsRightTableLayoutPanel.ColumnCount = 2;
            _cartsRightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _cartsRightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _cartsRightTableLayoutPanel.Controls.Add(_customerLabel, 0, 0);
            _cartsRightTableLayoutPanel.Controls.Add(_customerComboBox, 1, 0);
            _cartsRightTableLayoutPanel.Controls.Add(_cartLabel, 0, 1);
            _cartsRightTableLayoutPanel.Controls.Add(_cartListBox, 0, 2);
            _cartsRightTableLayoutPanel.Controls.Add(_amountLabel, 0, 3);
            _cartsRightTableLayoutPanel.Controls.Add(_amountValueLabel, 0, 4);
            _cartsRightTableLayoutPanel.Controls.Add(_cartsButtonsTableLayoutPanel, 0, 5);
            _cartsRightTableLayoutPanel.Dock = DockStyle.Fill;
            _cartsRightTableLayoutPanel.Location = new Point(444, 15);
            _cartsRightTableLayoutPanel.Name = "_cartsRightTableLayoutPanel";
            _cartsRightTableLayoutPanel.RowCount = 6;
            _cartsRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _cartsRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _cartsRightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _cartsRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _cartsRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _cartsRightTableLayoutPanel.RowStyles.Add(new RowStyle());
            _cartsRightTableLayoutPanel.Size = new Size(639, 687);
            _cartsRightTableLayoutPanel.TabIndex = 1;
            // 
            // _customerLabel
            // 
            _customerLabel.Anchor = AnchorStyles.Left;
            _customerLabel.AutoSize = true;
            _customerLabel.Location = new Point(3, 7);
            _customerLabel.Margin = new Padding(3, 0, 12, 0);
            _customerLabel.Name = "_customerLabel";
            _customerLabel.Size = new Size(75, 20);
            _customerLabel.TabIndex = 0;
            _customerLabel.Text = "Customer:";
            // 
            // _customerComboBox
            // 
            _customerComboBox.Dock = DockStyle.Fill;
            _customerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _customerComboBox.FormattingEnabled = true;
            _customerComboBox.Location = new Point(93, 3);
            _customerComboBox.Name = "_customerComboBox";
            _customerComboBox.Size = new Size(543, 28);
            _customerComboBox.TabIndex = 1;
            _customerComboBox.SelectedIndexChanged += _customerComboBox_SelectedIndexChanged;
            // 
            // _cartLabel
            // 
            _cartLabel.Anchor = AnchorStyles.Left;
            _cartLabel.AutoSize = true;
            _cartsRightTableLayoutPanel.SetColumnSpan(_cartLabel, 2);
            _cartLabel.Location = new Point(3, 46);
            _cartLabel.Margin = new Padding(3, 12, 3, 6);
            _cartLabel.Name = "_cartLabel";
            _cartLabel.Size = new Size(39, 20);
            _cartLabel.TabIndex = 2;
            _cartLabel.Text = "Cart:";
            // 
            // _cartListBox
            // 
            _cartsRightTableLayoutPanel.SetColumnSpan(_cartListBox, 2);
            _cartListBox.Dock = DockStyle.Fill;
            _cartListBox.FormattingEnabled = true;
            _cartListBox.Location = new Point(3, 75);
            _cartListBox.Name = "_cartListBox";
            _cartListBox.Size = new Size(633, 484);
            _cartListBox.TabIndex = 3;
            // 
            // _amountLabel
            // 
            _amountLabel.Anchor = AnchorStyles.Right;
            _amountLabel.AutoSize = true;
            _cartsRightTableLayoutPanel.SetColumnSpan(_amountLabel, 2);
            _amountLabel.Location = new Point(571, 568);
            _amountLabel.Margin = new Padding(3, 6, 3, 0);
            _amountLabel.Name = "_amountLabel";
            _amountLabel.Size = new Size(65, 20);
            _amountLabel.TabIndex = 4;
            _amountLabel.Text = "Amount:";
            // 
            // _amountValueLabel
            // 
            _amountValueLabel.Anchor = AnchorStyles.Right;
            _amountValueLabel.AutoSize = true;
            _cartsRightTableLayoutPanel.SetColumnSpan(_amountValueLabel, 2);
            _amountValueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _amountValueLabel.Location = new Point(603, 588);
            _amountValueLabel.Margin = new Padding(3, 0, 3, 6);
            _amountValueLabel.Name = "_amountValueLabel";
            _amountValueLabel.Size = new Size(33, 37);
            _amountValueLabel.TabIndex = 5;
            _amountValueLabel.Text = "0";
            _amountValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // _cartsButtonsTableLayoutPanel
            // 
            _cartsButtonsTableLayoutPanel.AutoSize = true;
            _cartsButtonsTableLayoutPanel.ColumnCount = 4;
            _cartsRightTableLayoutPanel.SetColumnSpan(_cartsButtonsTableLayoutPanel, 2);
            _cartsButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _cartsButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _cartsButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _cartsButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            _cartsButtonsTableLayoutPanel.Controls.Add(_createOrderButton, 0, 0);
            _cartsButtonsTableLayoutPanel.Controls.Add(_removeItemButton, 2, 0);
            _cartsButtonsTableLayoutPanel.Controls.Add(_clearCartButton, 3, 0);
            _cartsButtonsTableLayoutPanel.Dock = DockStyle.Fill;
            _cartsButtonsTableLayoutPanel.Location = new Point(0, 637);
            _cartsButtonsTableLayoutPanel.Margin = new Padding(0, 6, 0, 0);
            _cartsButtonsTableLayoutPanel.Name = "_cartsButtonsTableLayoutPanel";
            _cartsButtonsTableLayoutPanel.RowCount = 1;
            _cartsButtonsTableLayoutPanel.RowStyles.Add(new RowStyle());
            _cartsButtonsTableLayoutPanel.Size = new Size(639, 50);
            _cartsButtonsTableLayoutPanel.TabIndex = 6;
            // 
            // _createOrderButton
            // 
            _createOrderButton.Location = new Point(3, 3);
            _createOrderButton.Name = "_createOrderButton";
            _createOrderButton.Size = new Size(140, 44);
            _createOrderButton.TabIndex = 0;
            _createOrderButton.Text = "Create Order";
            _createOrderButton.UseVisualStyleBackColor = true;
            _createOrderButton.Click += _createOrderButton_Click;
            // 
            // _removeItemButton
            // 
            _removeItemButton.Location = new Point(350, 3);
            _removeItemButton.Name = "_removeItemButton";
            _removeItemButton.Size = new Size(140, 44);
            _removeItemButton.TabIndex = 1;
            _removeItemButton.Text = "Remove Item";
            _removeItemButton.UseVisualStyleBackColor = true;
            _removeItemButton.Click += _removeItemButton_Click;
            // 
            // _clearCartButton
            // 
            _clearCartButton.Location = new Point(496, 3);
            _clearCartButton.Name = "_clearCartButton";
            _clearCartButton.Size = new Size(140, 44);
            _clearCartButton.TabIndex = 2;
            _clearCartButton.Text = "Clear Cart";
            _clearCartButton.UseVisualStyleBackColor = true;
            _clearCartButton.Click += _clearCartButton_Click;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_cartsRootTableLayoutPanel);
            Name = "CartsTab";
            Size = new Size(1098, 717);
            _cartsRootTableLayoutPanel.ResumeLayout(false);
            _cartsLeftTableLayoutPanel.ResumeLayout(false);
            _cartsLeftTableLayoutPanel.PerformLayout();
            _cartsRightTableLayoutPanel.ResumeLayout(false);
            _cartsRightTableLayoutPanel.PerformLayout();
            _cartsButtonsTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel _cartsRootTableLayoutPanel;
        private TableLayoutPanel _cartsLeftTableLayoutPanel;
        private Label _itemsLabel;
        private ListBox _itemsListBox;
        private Button _addToCartButton;
        private TableLayoutPanel _cartsRightTableLayoutPanel;
        private Label _customerLabel;
        private ComboBox _customerComboBox;
        private Label _cartLabel;
        private ListBox _cartListBox;
        private Label _amountLabel;
        private Label _amountValueLabel;
        private TableLayoutPanel _cartsButtonsTableLayoutPanel;
        private Button _createOrderButton;
        private Button _removeItemButton;
        private Button _clearCartButton;
    }
}
