namespace Programming
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControlMain = new TabControl();
            tabPage1 = new TabPage();
            tabPageClasses = new TabPage();
            rectanglesClassesControl1 = new Programming.Model.Controls.RectanglesClassesControl();
            filmClassesControl1 = new Programming.Model.Controls.FilmClassesControl();
            tabPageRectangles = new TabPage();
            rectanglesCollisionControl1 = new Programming.Model.Controls.RectanglesCollisionControl();
            enumarationsEnumControl1 = new Programming.Model.Controls.EnumarationsEnumControl();
            seasonsHandleEnumControl1 = new Programming.Model.Controls.Enums.SeasonsHandleEnumControl();
            weekdayParsingEnumControl1 = new Programming.Model.Controls.Enums.WeekdayParsingEnumControl();
            TabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPageClasses.SuspendLayout();
            tabPageRectangles.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlMain
            // 
            TabControlMain.Controls.Add(tabPage1);
            TabControlMain.Controls.Add(tabPageClasses);
            TabControlMain.Controls.Add(tabPageRectangles);
            TabControlMain.Dock = DockStyle.Fill;
            TabControlMain.Location = new Point(0, 0);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(1177, 530);
            TabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(weekdayParsingEnumControl1);
            tabPage1.Controls.Add(seasonsHandleEnumControl1);
            tabPage1.Controls.Add(enumarationsEnumControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1169, 497);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;

            // 
            // tabPageClasses
            // 
            tabPageClasses.Controls.Add(rectanglesClassesControl1);
            tabPageClasses.Controls.Add(filmClassesControl1);
            tabPageClasses.Location = new Point(4, 29);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.Padding = new Padding(3);
            tabPageClasses.Size = new Size(1169, 497);
            tabPageClasses.TabIndex = 1;
            tabPageClasses.Text = "Classes";
            tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // rectanglesClassesControl1
            // 
            rectanglesClassesControl1.Location = new Point(0, 3);
            rectanglesClassesControl1.Name = "rectanglesClassesControl1";
            rectanglesClassesControl1.Size = new Size(521, 621);
            rectanglesClassesControl1.TabIndex = 1;
            // 
            // filmClassesControl1
            // 
            filmClassesControl1.Location = new Point(536, 6);
            filmClassesControl1.Name = "filmClassesControl1";
            filmClassesControl1.Size = new Size(564, 611);
            filmClassesControl1.TabIndex = 0;
            // 
            // tabPageRectangles
            // 
            tabPageRectangles.Controls.Add(rectanglesCollisionControl1);
            tabPageRectangles.Location = new Point(4, 29);
            tabPageRectangles.Name = "tabPageRectangles";
            tabPageRectangles.Padding = new Padding(3);
            tabPageRectangles.Size = new Size(1169, 497);
            tabPageRectangles.TabIndex = 3;
            tabPageRectangles.Text = "Rectangles";
            tabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(1163, 491);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // enumarationsEnumControl1
            // 
            enumarationsEnumControl1.Location = new Point(0, 0);
            enumarationsEnumControl1.Name = "enumarationsEnumControl1";
            enumarationsEnumControl1.Size = new Size(854, 452);
            enumarationsEnumControl1.TabIndex = 0;
            // 
            // seasonsHandleEnumControl1
            // 
            seasonsHandleEnumControl1.Location = new Point(510, 348);
            seasonsHandleEnumControl1.Name = "seasonsHandleEnumControl1";
            seasonsHandleEnumControl1.Size = new Size(506, 204);
            seasonsHandleEnumControl1.TabIndex = 1;
            // 
            // weekdayParsingEnumControl1
            // 
            weekdayParsingEnumControl1.Location = new Point(8, 348);
            weekdayParsingEnumControl1.Name = "weekdayParsingEnumControl1";
            weekdayParsingEnumControl1.Size = new Size(496, 202);
            weekdayParsingEnumControl1.TabIndex = 2;
            // 
            // Form1
            // 
            ClientSize = new Size(1177, 530);
            Controls.Add(TabControlMain);
            Name = "Form1";
            Text = "Programming";
            TabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPageClasses.ResumeLayout(false);
            tabPageRectangles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ?? Объявления полей элементов управления
        private TabControl TabControlMain;
        private TabPage tabPage1;
        private TabPage tabPageRectangles;
        private Model.Controls.RectanglesCollisionControl rectanglesCollisionControl1;
        private TabPage tabPageClasses;
        private Model.Controls.RectanglesClassesControl rectanglesClassesControl1;
        private Model.Controls.FilmClassesControl filmClassesControl1;
        private Model.Controls.Enums.WeekdayParsingEnumControl weekdayParsingEnumControl1;
        private Model.Controls.Enums.SeasonsHandleEnumControl seasonsHandleEnumControl1;
        private Model.Controls.EnumarationsEnumControl enumarationsEnumControl1;
    }
}