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
            _itemsLabel = new Label();
            _itemsListBox = new ListBox();
            _addButton = new Button();
            _removeButton = new Button();
            _itemGroupBox = new GroupBox();
            _descriptionTextBox = new TextBox();
            _nameTextBox = new TextBox();
            _descriptionLabel = new Label();
            _nameLabel = new Label();
            _costTextBox = new TextBox();
            _idTextBox = new TextBox();
            _costLabel = new Label();
            _idLabel = new Label();
            _itemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // _itemsLabel
            // 
            _itemsLabel.AutoSize = true;
            _itemsLabel.Location = new Point(12, 13);
            _itemsLabel.Name = "_itemsLabel";
            _itemsLabel.Size = new Size(45, 20);
            _itemsLabel.TabIndex = 0;
            _itemsLabel.Text = "Items";
            // 
            // _itemsListBox
            // 
            _itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            _itemsListBox.FormattingEnabled = true;
            _itemsListBox.Location = new Point(12, 46);
            _itemsListBox.Name = "_itemsListBox";
            _itemsListBox.Size = new Size(340, 504);
            _itemsListBox.TabIndex = 1;
            _itemsListBox.SelectedIndexChanged += _itemsListBox_SelectedIndexChanged;
            // 
            // _addButton
            // 
            _addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _addButton.Location = new Point(12, 558);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(106, 53);
            _addButton.TabIndex = 2;
            _addButton.Text = "Add";
            _addButton.UseVisualStyleBackColor = true;
            _addButton.Click += _addButton_Click;
            // 
            // _removeButton
            // 
            _removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _removeButton.Location = new Point(138, 558);
            _removeButton.Name = "_removeButton";
            _removeButton.Size = new Size(106, 53);
            _removeButton.TabIndex = 3;
            _removeButton.Text = "Remove";
            _removeButton.UseVisualStyleBackColor = true;
            _removeButton.Click += _removeButton_Click;
            // 
            // _itemGroupBox
            // 
            _itemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _itemGroupBox.Controls.Add(_descriptionTextBox);
            _itemGroupBox.Controls.Add(_nameTextBox);
            _itemGroupBox.Controls.Add(_descriptionLabel);
            _itemGroupBox.Controls.Add(_nameLabel);
            _itemGroupBox.Controls.Add(_costTextBox);
            _itemGroupBox.Controls.Add(_idTextBox);
            _itemGroupBox.Controls.Add(_costLabel);
            _itemGroupBox.Controls.Add(_idLabel);
            _itemGroupBox.Location = new Point(370, 46);
            _itemGroupBox.Name = "_itemGroupBox";
            _itemGroupBox.Size = new Size(511, 565);
            _itemGroupBox.TabIndex = 4;
            _itemGroupBox.TabStop = false;
            _itemGroupBox.Text = "Selected Item";
            // 
            // _descriptionTextBox
            // 
            _descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _descriptionTextBox.Location = new Point(0, 302);
            _descriptionTextBox.Multiline = true;
            _descriptionTextBox.Name = "_descriptionTextBox";
            _descriptionTextBox.Size = new Size(486, 202);
            _descriptionTextBox.TabIndex = 7;
            _descriptionTextBox.TextChanged += _descriptionTextBox_TextChanged;
            // 
            // _nameTextBox
            // 
            _nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _nameTextBox.Location = new Point(0, 151);
            _nameTextBox.Multiline = true;
            _nameTextBox.Name = "_nameTextBox";
            _nameTextBox.Size = new Size(486, 115);
            _nameTextBox.TabIndex = 6;
            _nameTextBox.TextChanged += _nameTextBox_TextChanged;
            // 
            // _descriptionLabel
            // 
            _descriptionLabel.AutoSize = true;
            _descriptionLabel.Location = new Point(0, 279);
            _descriptionLabel.Name = "_descriptionLabel";
            _descriptionLabel.Size = new Size(88, 20);
            _descriptionLabel.TabIndex = 5;
            _descriptionLabel.Text = "Description:";
            // 
            // _nameLabel
            // 
            _nameLabel.AutoSize = true;
            _nameLabel.Location = new Point(0, 128);
            _nameLabel.Name = "_nameLabel";
            _nameLabel.Size = new Size(52, 20);
            _nameLabel.TabIndex = 4;
            _nameLabel.Text = "Name:";
            // 
            // _costTextBox
            // 
            _costTextBox.Location = new Point(50, 83);
            _costTextBox.Name = "_costTextBox";
            _costTextBox.Size = new Size(125, 27);
            _costTextBox.TabIndex = 3;
            _costTextBox.TextChanged += _costTextBox_TextChanged;
            // 
            // _idTextBox
            // 
            _idTextBox.Location = new Point(50, 43);
            _idTextBox.Name = "_idTextBox";
            _idTextBox.ReadOnly = true;
            _idTextBox.Size = new Size(125, 27);
            _idTextBox.TabIndex = 2;
            // 
            // _costLabel
            // 
            _costLabel.AutoSize = true;
            _costLabel.Location = new Point(3, 86);
            _costLabel.Name = "_costLabel";
            _costLabel.Size = new Size(41, 20);
            _costLabel.TabIndex = 1;
            _costLabel.Text = "Cost:";
            // 
            // _idLabel
            // 
            _idLabel.AutoSize = true;
            _idLabel.Location = new Point(3, 46);
            _idLabel.Name = "_idLabel";
            _idLabel.Size = new Size(27, 20);
            _idLabel.TabIndex = 0;
            _idLabel.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_itemGroupBox);
            Controls.Add(_removeButton);
            Controls.Add(_addButton);
            Controls.Add(_itemsListBox);
            Controls.Add(_itemsLabel);
            Name = "ItemsTab";
            Size = new Size(907, 639);
            _itemGroupBox.ResumeLayout(false);
            _itemGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _itemsLabel;
        private ListBox _itemsListBox;
        private Button _addButton;
        private Button _removeButton;
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
