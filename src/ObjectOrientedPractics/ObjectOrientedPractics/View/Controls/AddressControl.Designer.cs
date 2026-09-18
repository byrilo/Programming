namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            _addressMainLabel = new Label();
            _postIndexLabel = new Label();
            _countryLabel = new Label();
            _streetLabel = new Label();
            _buildingLabel = new Label();
            _cityLabel = new Label();
            _apartmentLabel = new Label();
            _postIndexTextBox = new TextBox();
            _countryTextBox = new TextBox();
            _streetTextBox = new TextBox();
            _cityTextBox = new TextBox();
            _buildingTextBox = new TextBox();
            _apartmentTextBox = new TextBox();
            SuspendLayout();
            // 
            // _addressMainLabel
            // 
            _addressMainLabel.AutoSize = true;
            _addressMainLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            _addressMainLabel.Location = new Point(20, 27);
            _addressMainLabel.Name = "_addressMainLabel";
            _addressMainLabel.Size = new Size(135, 20);
            _addressMainLabel.TabIndex = 0;
            _addressMainLabel.Text = "Delivery Address";
            // 
            // _postIndexLabel
            // 
            _postIndexLabel.AutoSize = true;
            _postIndexLabel.Location = new Point(20, 78);
            _postIndexLabel.Name = "_postIndexLabel";
            _postIndexLabel.Size = new Size(79, 20);
            _postIndexLabel.TabIndex = 1;
            _postIndexLabel.Text = "Post index:";
            // 
            // _countryLabel
            // 
            _countryLabel.AutoSize = true;
            _countryLabel.Location = new Point(20, 121);
            _countryLabel.Name = "_countryLabel";
            _countryLabel.Size = new Size(63, 20);
            _countryLabel.TabIndex = 2;
            _countryLabel.Text = "Country:";
            // 
            // _streetLabel
            // 
            _streetLabel.AutoSize = true;
            _streetLabel.Location = new Point(20, 166);
            _streetLabel.Name = "_streetLabel";
            _streetLabel.Size = new Size(51, 20);
            _streetLabel.TabIndex = 3;
            _streetLabel.Text = "Street:";
            // 
            // _buildingLabel
            // 
            _buildingLabel.AutoSize = true;
            _buildingLabel.Location = new Point(20, 214);
            _buildingLabel.Name = "_buildingLabel";
            _buildingLabel.Size = new Size(67, 20);
            _buildingLabel.TabIndex = 4;
            _buildingLabel.Text = "Building:";
            // 
            // _cityLabel
            // 
            _cityLabel.AutoSize = true;
            _cityLabel.Location = new Point(301, 125);
            _cityLabel.Name = "_cityLabel";
            _cityLabel.Size = new Size(37, 20);
            _cityLabel.TabIndex = 5;
            _cityLabel.Text = "City:";
            // 
            // _apartmentLabel
            // 
            _apartmentLabel.AutoSize = true;
            _apartmentLabel.Location = new Point(247, 217);
            _apartmentLabel.Name = "_apartmentLabel";
            _apartmentLabel.Size = new Size(83, 20);
            _apartmentLabel.TabIndex = 6;
            _apartmentLabel.Text = "Apartment:";
            // 
            // _postIndexTextBox
            // 
            _postIndexTextBox.Location = new Point(105, 75);
            _postIndexTextBox.Name = "_postIndexTextBox";
            _postIndexTextBox.Size = new Size(125, 27);
            _postIndexTextBox.TabIndex = 7;
            // 
            // _countryTextBox
            // 
            _countryTextBox.Location = new Point(105, 121);
            _countryTextBox.Name = "_countryTextBox";
            _countryTextBox.Size = new Size(190, 27);
            _countryTextBox.TabIndex = 8;
            // 
            // _streetTextBox
            // 
            _streetTextBox.Location = new Point(105, 166);
            _streetTextBox.Name = "_streetTextBox";
            _streetTextBox.Size = new Size(412, 27);
            _streetTextBox.TabIndex = 9;
            // 
            // _cityTextBox
            // 
            _cityTextBox.Location = new Point(344, 125);
            _cityTextBox.Name = "_cityTextBox";
            _cityTextBox.Size = new Size(173, 27);
            _cityTextBox.TabIndex = 10;
            // 
            // _buildingTextBox
            // 
            _buildingTextBox.Location = new Point(105, 214);
            _buildingTextBox.Name = "_buildingTextBox";
            _buildingTextBox.Size = new Size(125, 27);
            _buildingTextBox.TabIndex = 11;
            // 
            // _apartmentTextBox
            // 
            _apartmentTextBox.Location = new Point(344, 217);
            _apartmentTextBox.Name = "_apartmentTextBox";
            _apartmentTextBox.Size = new Size(125, 27);
            _apartmentTextBox.TabIndex = 12;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_apartmentTextBox);
            Controls.Add(_buildingTextBox);
            Controls.Add(_cityTextBox);
            Controls.Add(_streetTextBox);
            Controls.Add(_countryTextBox);
            Controls.Add(_postIndexTextBox);
            Controls.Add(_apartmentLabel);
            Controls.Add(_cityLabel);
            Controls.Add(_buildingLabel);
            Controls.Add(_streetLabel);
            Controls.Add(_countryLabel);
            Controls.Add(_postIndexLabel);
            Controls.Add(_addressMainLabel);
            Name = "AddressControl";
            Size = new Size(550, 261);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _addressMainLabel;
        private Label _postIndexLabel;
        private Label _countryLabel;
        private Label _streetLabel;
        private Label _buildingLabel;
        private Label _cityLabel;
        private Label _apartmentLabel;
        private TextBox _postIndexTextBox;
        private TextBox _countryTextBox;
        private TextBox _streetTextBox;
        private TextBox _cityTextBox;
        private TextBox _buildingTextBox;
        private TextBox _apartmentTextBox;
    }
}
