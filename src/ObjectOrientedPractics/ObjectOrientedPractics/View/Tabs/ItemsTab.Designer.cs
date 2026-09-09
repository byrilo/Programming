namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            _itemsRootTableLayoutPanel = new TableLayoutPanel();
            _itemsLeftTableLayoutPanel = new TableLayoutPanel();
            _itemsLabel = new Label();
            _itemsListBox = new ListBox();
            _itemsButtonsFlowPanel = new FlowLayoutPanel();
            _addButton = new Button();
            _removeButton = new Button();
            _itemsRandomButton = new Button();
            _itemGroupBox = new GroupBox();
            _descriptionTextBox = new TextBox();
            _nameTextBox = new TextBox();
            _descriptionLabel = new Label();
            _nameLabel = new Label();
            _costTextBox = new TextBox();
            _idTextBox = new TextBox();
            _costLabel = new Label();
            _idLabel = new Label();
            _itemsRootTableLayoutPanel.SuspendLayout();
            _itemsLeftTableLayoutPanel.SuspendLayout();
            _itemsButtonsFlowPanel.SuspendLayout();
            _itemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // _itemsRootTableLayoutPanel
            // 
            _itemsRootTableLayoutPanel.ColumnCount = 2;
            _itemsRootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            _itemsRootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            _itemsRootTableLayoutPanel.Controls.Add(_itemsLeftTableLayoutPanel, 0, 0);
            _itemsRootTableLayoutPanel.Controls.Add(_itemGroupBox, 1, 0);
            _itemsRootTableLayoutPanel.Dock = DockStyle.Fill;
            _itemsRootTableLayoutPanel.Location = new Point(0, 0);
            _itemsRootTableLayoutPanel.Name = "_itemsRootTableLayoutPanel";
            _itemsRootTableLayoutPanel.Padding = new Padding(12);
            _itemsRootTableLayoutPanel.RowCount = 1;
            _itemsRootTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _itemsRootTableLayoutPanel.Size = new Size(907, 639);
            _itemsRootTableLayoutPanel.TabIndex = 0;
            // 
            // _itemsLeftTableLayoutPanel
            // 
            _itemsLeftTableLayoutPanel.ColumnCount = 1;
            _itemsLeftTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _itemsLeftTableLayoutPanel.Controls.Add(_itemsLabel, 0, 0);
            _itemsLeftTableLayoutPanel.Controls.Add(_itemsListBox, 0, 1);
            _itemsLeftTableLayoutPanel.Controls.Add(_itemsButtonsFlowPanel, 0, 2);
            _itemsLeftTableLayoutPanel.Dock = DockStyle.Fill;
            _itemsLeftTableLayoutPanel.Location = new Point(15, 15);
            _itemsLeftTableLayoutPanel.Margin = new Padding(3, 3, 12, 3);
            _itemsLeftTableLayoutPanel.Name = "_itemsLeftTableLayoutPanel";
            _itemsLeftTableLayoutPanel.RowCount = 3;
            _itemsLeftTableLayoutPanel.RowStyles.Add(new RowStyle());
            _itemsLeftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _itemsLeftTableLayoutPanel.RowStyles.Add(new RowStyle());
            _itemsLeftTableLayoutPanel.Size = new Size(338, 609);
            _itemsLeftTableLayoutPanel.TabIndex = 0;
            // 
            // _itemsLabel
            // 
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
            _itemsListBox.Size = new Size(332, 515);
            _itemsListBox.TabIndex = 1;
            _itemsListBox.SelectedIndexChanged += _itemsListBox_SelectedIndexChanged;
            // 
            // _itemsButtonsFlowPanel
            // 
            _itemsButtonsFlowPanel.AutoSize = true;
            _itemsButtonsFlowPanel.Controls.Add(_addButton);
            _itemsButtonsFlowPanel.Controls.Add(_removeButton);
            _itemsButtonsFlowPanel.Controls.Add(_itemsRandomButton);
            _itemsButtonsFlowPanel.Dock = DockStyle.Fill;
            _itemsButtonsFlowPanel.Location = new Point(3, 556);
            _itemsButtonsFlowPanel.Margin = new Padding(3, 6, 3, 3);
            _itemsButtonsFlowPanel.Name = "_itemsButtonsFlowPanel";
            _itemsButtonsFlowPanel.Size = new Size(332, 50);
            _itemsButtonsFlowPanel.TabIndex = 2;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(3, 3);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(100, 44);
            _addButton.TabIndex = 0;
            _addButton.Text = "Add";
            _addButton.UseVisualStyleBackColor = true;
            _addButton.Click += _addButton_Click;
            // 
            // _removeButton
            // 
            _removeButton.Location = new Point(109, 3);
            _removeButton.Name = "_removeButton";
            _removeButton.Size = new Size(100, 44);
            _removeButton.TabIndex = 1;
            _removeButton.Text = "Remove";
            _removeButton.UseVisualStyleBackColor = true;
            _removeButton.Click += _removeButton_Click;
            // 
            // _itemsRandomButton
            // 
            _itemsRandomButton.Location = new Point(215, 3);
            _itemsRandomButton.Name = "_itemsRandomButton";
            _itemsRandomButton.Size = new Size(100, 44);
            _itemsRandomButton.TabIndex = 2;
            _itemsRandomButton.Text = "Random";
            _itemsRandomButton.UseVisualStyleBackColor = true;
            _itemsRandomButton.Click += _itemsRandomButton_Click;
            // 
            // _itemGroupBox
            // 
            _itemGroupBox.Controls.Add(_descriptionTextBox);
            _itemGroupBox.Controls.Add(_nameTextBox);
            _itemGroupBox.Controls.Add(_descriptionLabel);
            _itemGroupBox.Controls.Add(_nameLabel);
            _itemGroupBox.Controls.Add(_costTextBox);
            _itemGroupBox.Controls.Add(_idTextBox);
            _itemGroupBox.Controls.Add(_costLabel);
            _itemGroupBox.Controls.Add(_idLabel);
            _itemGroupBox.Dock = DockStyle.Fill;
            _itemGroupBox.Location = new Point(377, 15);
            _itemGroupBox.Margin = new Padding(12, 3, 3, 3);
            _itemGroupBox.Name = "_itemGroupBox";
            _itemGroupBox.Size = new Size(515, 609);
            _itemGroupBox.TabIndex = 1;
            _itemGroupBox.TabStop = false;
            _itemGroupBox.Text = "Selected Item";
            // 
            // _descriptionTextBox
            // 
            _descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _descriptionTextBox.Location = new Point(6, 302);
            _descriptionTextBox.Multiline = true;
            _descriptionTextBox.Name = "_descriptionTextBox";
            _descriptionTextBox.Size = new Size(497, 296);
            _descriptionTextBox.TabIndex = 7;
            _descriptionTextBox.TextChanged += _descriptionTextBox_TextChanged;
            // 
            // _nameTextBox
            // 
            _nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _nameTextBox.Location = new Point(6, 151);
            _nameTextBox.Multiline = true;
            _nameTextBox.Name = "_nameTextBox";
            _nameTextBox.Size = new Size(497, 115);
            _nameTextBox.TabIndex = 6;
            _nameTextBox.TextChanged += _nameTextBox_TextChanged;
            // 
            // _descriptionLabel
            // 
            _descriptionLabel.AutoSize = true;
            _descriptionLabel.Location = new Point(6, 279);
            _descriptionLabel.Name = "_descriptionLabel";
            _descriptionLabel.Size = new Size(88, 20);
            _descriptionLabel.TabIndex = 5;
            _descriptionLabel.Text = "Description:";
            // 
            // _nameLabel
            // 
            _nameLabel.AutoSize = true;
            _nameLabel.Location = new Point(6, 128);
            _nameLabel.Name = "_nameLabel";
            _nameLabel.Size = new Size(52, 20);
            _nameLabel.TabIndex = 4;
            _nameLabel.Text = "Name:";
            // 
            // _costTextBox
            // 
            _costTextBox.Location = new Point(56, 83);
            _costTextBox.Name = "_costTextBox";
            _costTextBox.Size = new Size(125, 27);
            _costTextBox.TabIndex = 3;
            _costTextBox.TextChanged += _costTextBox_TextChanged;
            // 
            // _idTextBox
            // 
            _idTextBox.Location = new Point(56, 43);
            _idTextBox.Name = "_idTextBox";
            _idTextBox.ReadOnly = true;
            _idTextBox.Size = new Size(125, 27);
            _idTextBox.TabIndex = 2;
            // 
            // _costLabel
            // 
            _costLabel.AutoSize = true;
            _costLabel.Location = new Point(6, 86);
            _costLabel.Name = "_costLabel";
            _costLabel.Size = new Size(41, 20);
            _costLabel.TabIndex = 1;
            _costLabel.Text = "Cost:";
            // 
            // _idLabel
            // 
            _idLabel.AutoSize = true;
            _idLabel.Location = new Point(6, 46);
            _idLabel.Name = "_idLabel";
            _idLabel.Size = new Size(27, 20);
            _idLabel.TabIndex = 0;
            _idLabel.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_itemsRootTableLayoutPanel);
            Name = "ItemsTab";
            Size = new Size(907, 639);
            _itemsRootTableLayoutPanel.ResumeLayout(false);
            _itemsLeftTableLayoutPanel.ResumeLayout(false);
            _itemsLeftTableLayoutPanel.PerformLayout();
            _itemsButtonsFlowPanel.ResumeLayout(false);
            _itemGroupBox.ResumeLayout(false);
            _itemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel _itemsRootTableLayoutPanel;
        private TableLayoutPanel _itemsLeftTableLayoutPanel;
        private Label _itemsLabel;
        private ListBox _itemsListBox;
        private FlowLayoutPanel _itemsButtonsFlowPanel;
        private Button _addButton;
        private Button _removeButton;
        private Button _itemsRandomButton;
        private GroupBox _itemGroupBox;
        private TextBox _costTextBox;
        private TextBox _idTextBox;
        private Label _costLabel;
        private Label _idLabel;
        private TextBox _descriptionTextBox;
        private TextBox _nameTextBox;
        private Label _descriptionLabel;
        private Label _nameLabel;
    }
}
