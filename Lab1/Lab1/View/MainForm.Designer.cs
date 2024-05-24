namespace Lab1
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
            tabPage1 = new TabControl();
            EnumsTabs = new TabPage();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            weekDayControl1 = new Model.Tabs.WeekDayControl();
            groupBox1 = new GroupBox();
            enumsControl1 = new Model.Tabs.EnumsControl();
            tabPage2 = new TabPage();
            moviesControl1 = new Model.Tabs.MoviesControl();
            rectanglesControl1 = new Model.Tabs.RectanglesControl();
            tabPage3 = new TabPage();
            rectanglesCollisionControl1 = new Model.Tabs.RectanglesCollisionControl();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            seasonControl1 = new Model.Tabs.SeasonControl();
            tabPage1.SuspendLayout();
            EnumsTabs.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(EnumsTabs);
            tabPage1.Controls.Add(tabPage2);
            tabPage1.Controls.Add(tabPage3);
            tabPage1.Dock = DockStyle.Fill;
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.SelectedIndex = 0;
            tabPage1.Size = new Size(836, 664);
            tabPage1.TabIndex = 0;
            // 
            // EnumsTabs
            // 
            EnumsTabs.Controls.Add(groupBox3);
            EnumsTabs.Controls.Add(groupBox2);
            EnumsTabs.Controls.Add(groupBox1);
            EnumsTabs.Location = new Point(4, 24);
            EnumsTabs.Name = "EnumsTabs";
            EnumsTabs.Padding = new Padding(3);
            EnumsTabs.Size = new Size(828, 636);
            EnumsTabs.TabIndex = 0;
            EnumsTabs.Text = "Enums";
            EnumsTabs.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(seasonControl1);
            groupBox3.Location = new Point(398, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 135);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Season Handle";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(weekDayControl1);
            groupBox2.Location = new Point(14, 317);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 150);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekday Parsing";
            // 
            // weekDayControl1
            // 
            weekDayControl1.Location = new Point(6, 38);
            weekDayControl1.Name = "weekDayControl1";
            weekDayControl1.Size = new Size(294, 97);
            weekDayControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(enumsControl1);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 305);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
            // 
            // enumsControl1
            // 
            enumsControl1.Location = new Point(0, 22);
            enumsControl1.Name = "enumsControl1";
            enumsControl1.Size = new Size(474, 155);
            enumsControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(moviesControl1);
            tabPage2.Controls.Add(rectanglesControl1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(828, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // moviesControl1
            // 
            moviesControl1.Location = new Point(415, 47);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(405, 314);
            moviesControl1.TabIndex = 3;
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Location = new Point(8, 47);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(319, 290);
            rectanglesControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(rectanglesCollisionControl1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(828, 636);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rectangles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Location = new Point(0, 6);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(828, 576);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // seasonControl1
            // 
            seasonControl1.Location = new Point(0, 38);
            seasonControl1.Name = "seasonControl1";
            seasonControl1.Size = new Size(231, 64);
            seasonControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 664);
            Controls.Add(tabPage1);
            Name = "MainForm";
            Text = "Form1";
            tabPage1.ResumeLayout(false);
            EnumsTabs.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPage1;
        private TabPage EnumsTabs;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Model.Tabs.RectanglesCollisionControl rectanglesCollisionControl1;
        private Model.Tabs.RectanglesControl rectanglesControl1;
        private Model.Tabs.MoviesControl moviesControl1;
        private Model.Tabs.EnumsControl enumsControl1;
        private Model.Tabs.WeekDayControl weekDayControl1;
        private Model.Tabs.SeasonControl seasonControl1;
    }
}
