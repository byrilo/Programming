using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>Диалог выбора категории процентной скидки.</summary>
    internal sealed class DiscountCategoryForm : Form
    {
        private readonly ComboBox _categoryComboBox;

        /// <summary>Возвращает выбранную категорию товаров.</summary>
        public Category SelectedCategory => (Category)_categoryComboBox.SelectedItem!;

        /// <summary>Создаёт диалог выбора категории.</summary>
        /// <param name="categories">Категории, для которых скидка ещё не добавлена.</param>
        public DiscountCategoryForm(Category[] categories)
        {
            Text = "Add Discount";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ClientSize = new Size(320, 100);
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;

            var categoryLabel = new Label { Text = "Category:", AutoSize = true, Location = new Point(12, 16) };
            _categoryComboBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(100, 12),
                Width = 208,
                DataSource = categories
            };
            var okButton = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(152, 58) };
            var cancelButton = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Location = new Point(233, 58) };

            Controls.AddRange(new Control[] { categoryLabel, _categoryComboBox, okButton, cancelButton });
            AcceptButton = okButton;
            CancelButton = cancelButton;
        }
    }
}
