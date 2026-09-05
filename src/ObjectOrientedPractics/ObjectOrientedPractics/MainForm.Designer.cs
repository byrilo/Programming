namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _tabControl = new TabControl();
            _itemsTabPage = new TabPage();
            _itemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            _tabControl.SuspendLayout();
            _itemsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // _tabControl
            // 
            _tabControl.Controls.Add(_itemsTabPage);
            _tabControl.Dock = DockStyle.Fill;
            _tabControl.Location = new Point(0, 0);
            _tabControl.Name = "_tabControl";
            _tabControl.SelectedIndex = 0;
            _tabControl.Size = new Size(1112, 756);
            _tabControl.TabIndex = 0;
            // 
            // _itemsTabPage
            // 
            _itemsTabPage.Controls.Add(_itemsTab);
            _itemsTabPage.Location = new Point(4, 29);
            _itemsTabPage.Name = "_itemsTabPage";
            _itemsTabPage.Padding = new Padding(3);
            _itemsTabPage.Size = new Size(1104, 723);
            _itemsTabPage.TabIndex = 0;
            _itemsTabPage.Text = "Items";
            _itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // _itemsTab
            // 
            _itemsTab.Dock = DockStyle.Fill;
            _itemsTab.Location = new Point(3, 3);
            _itemsTab.Name = "_itemsTab";
            _itemsTab.Size = new Size(1098, 717);
            _itemsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 756);
            Controls.Add(_tabControl);
            Name = "MainForm";
            Text = "Form1";
            _tabControl.ResumeLayout(false);
            _itemsTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl _tabControl;
        private TabPage _itemsTabPage;
        private View.Tabs.ItemsTab _itemsTab;
    }
}
