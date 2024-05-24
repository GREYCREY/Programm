namespace Lab1.Model.Tabs
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            ListBoxOfRectangles = new ListBox();
            panelOfRectangles = new Panel();
            textBoxOfLenghtRectangle = new TextBox();
            textBoxOfWidthRectangle = new TextBox();
            textBoxOfYRectangle = new TextBox();
            textBoxOfXRectangle = new TextBox();
            textBoxlOfIDRectangle = new TextBox();
            labelOfLenghtRectangle = new Label();
            labelOfWidthRectangle = new Label();
            labelOfYRectangle = new Label();
            labelOfXRectangle = new Label();
            labelOfIDRectangle = new Label();
            labelOfSelectedRectangle = new Label();
            RemoveRectanlgeButton = new Button();
            AddRectangleButton = new Button();
            LabelOfRectangles = new Label();
            SuspendLayout();
            // 
            // ListBoxOfRectangles
            // 
            ListBoxOfRectangles.FormattingEnabled = true;
            ListBoxOfRectangles.ItemHeight = 15;
            ListBoxOfRectangles.Location = new Point(3, 63);
            ListBoxOfRectangles.Name = "ListBoxOfRectangles";
            ListBoxOfRectangles.Size = new Size(223, 109);
            ListBoxOfRectangles.TabIndex = 32;
            ListBoxOfRectangles.SelectedIndexChanged += ListBoxOfRectangles_SelectedIndexChanged;
            // 
            // panelOfRectangles
            // 
            panelOfRectangles.BorderStyle = BorderStyle.FixedSingle;
            panelOfRectangles.Location = new Point(250, 3);
            panelOfRectangles.Name = "panelOfRectangles";
            panelOfRectangles.Size = new Size(525, 567);
            panelOfRectangles.TabIndex = 31;
            // 
            // textBoxOfLenghtRectangle
            // 
            textBoxOfLenghtRectangle.Location = new Point(58, 347);
            textBoxOfLenghtRectangle.Name = "textBoxOfLenghtRectangle";
            textBoxOfLenghtRectangle.Size = new Size(100, 23);
            textBoxOfLenghtRectangle.TabIndex = 30;
            textBoxOfLenghtRectangle.TextChanged += textBoxOfLenghtRectangle_TextChanged;
            // 
            // textBoxOfWidthRectangle
            // 
            textBoxOfWidthRectangle.Location = new Point(58, 318);
            textBoxOfWidthRectangle.Name = "textBoxOfWidthRectangle";
            textBoxOfWidthRectangle.Size = new Size(100, 23);
            textBoxOfWidthRectangle.TabIndex = 29;
            textBoxOfWidthRectangle.TextChanged += textBoxOfWidthRectangle_TextChanged;
            // 
            // textBoxOfYRectangle
            // 
            textBoxOfYRectangle.Location = new Point(58, 289);
            textBoxOfYRectangle.Name = "textBoxOfYRectangle";
            textBoxOfYRectangle.Size = new Size(100, 23);
            textBoxOfYRectangle.TabIndex = 28;
            textBoxOfYRectangle.TextChanged += textBoxOfYRectangle_TextChanged;
            // 
            // textBoxOfXRectangle
            // 
            textBoxOfXRectangle.Location = new Point(58, 260);
            textBoxOfXRectangle.Name = "textBoxOfXRectangle";
            textBoxOfXRectangle.Size = new Size(100, 23);
            textBoxOfXRectangle.TabIndex = 27;
            textBoxOfXRectangle.TextChanged += textBoxOfXRectangle_TextChanged;
            // 
            // textBoxlOfIDRectangle
            // 
            textBoxlOfIDRectangle.Location = new Point(58, 231);
            textBoxlOfIDRectangle.Name = "textBoxlOfIDRectangle";
            textBoxlOfIDRectangle.Size = new Size(100, 23);
            textBoxlOfIDRectangle.TabIndex = 26;
            // 
            // labelOfLenghtRectangle
            // 
            labelOfLenghtRectangle.AutoSize = true;
            labelOfLenghtRectangle.Location = new Point(5, 355);
            labelOfLenghtRectangle.Name = "labelOfLenghtRectangle";
            labelOfLenghtRectangle.Size = new Size(47, 15);
            labelOfLenghtRectangle.TabIndex = 25;
            labelOfLenghtRectangle.Text = "Lenght:";
            // 
            // labelOfWidthRectangle
            // 
            labelOfWidthRectangle.AutoSize = true;
            labelOfWidthRectangle.Location = new Point(10, 326);
            labelOfWidthRectangle.Name = "labelOfWidthRectangle";
            labelOfWidthRectangle.Size = new Size(42, 15);
            labelOfWidthRectangle.TabIndex = 24;
            labelOfWidthRectangle.Text = "Width:";
            // 
            // labelOfYRectangle
            // 
            labelOfYRectangle.AutoSize = true;
            labelOfYRectangle.Location = new Point(35, 297);
            labelOfYRectangle.Name = "labelOfYRectangle";
            labelOfYRectangle.Size = new Size(17, 15);
            labelOfYRectangle.TabIndex = 23;
            labelOfYRectangle.Text = "Y:";
            // 
            // labelOfXRectangle
            // 
            labelOfXRectangle.AutoSize = true;
            labelOfXRectangle.Location = new Point(35, 268);
            labelOfXRectangle.Name = "labelOfXRectangle";
            labelOfXRectangle.Size = new Size(17, 15);
            labelOfXRectangle.TabIndex = 22;
            labelOfXRectangle.Text = "X:";
            // 
            // labelOfIDRectangle
            // 
            labelOfIDRectangle.AutoSize = true;
            labelOfIDRectangle.Location = new Point(35, 239);
            labelOfIDRectangle.Name = "labelOfIDRectangle";
            labelOfIDRectangle.Size = new Size(21, 15);
            labelOfIDRectangle.TabIndex = 21;
            labelOfIDRectangle.Text = "ID:";
            // 
            // labelOfSelectedRectangle
            // 
            labelOfSelectedRectangle.AutoSize = true;
            labelOfSelectedRectangle.Location = new Point(58, 198);
            labelOfSelectedRectangle.Name = "labelOfSelectedRectangle";
            labelOfSelectedRectangle.Size = new Size(112, 15);
            labelOfSelectedRectangle.TabIndex = 20;
            labelOfSelectedRectangle.Text = "Selected Rectangle: ";
            // 
            // RemoveRectanlgeButton
            // 
            RemoveRectanlgeButton.FlatStyle = FlatStyle.Flat;
            RemoveRectanlgeButton.Image = (Image)resources.GetObject("RemoveRectanlgeButton.Image");
            RemoveRectanlgeButton.Location = new Point(194, 178);
            RemoveRectanlgeButton.Name = "RemoveRectanlgeButton";
            RemoveRectanlgeButton.Size = new Size(32, 35);
            RemoveRectanlgeButton.TabIndex = 19;
            RemoveRectanlgeButton.UseVisualStyleBackColor = true;
            RemoveRectanlgeButton.Click += RemoveRectanlgeButton_Click;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.Image = (Image)resources.GetObject("AddRectangleButton.Image");
            AddRectangleButton.Location = new Point(3, 178);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(32, 35);
            AddRectangleButton.TabIndex = 18;
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click;
            // 
            // LabelOfRectangles
            // 
            LabelOfRectangles.AutoSize = true;
            LabelOfRectangles.Location = new Point(3, 45);
            LabelOfRectangles.Name = "LabelOfRectangles";
            LabelOfRectangles.Size = new Size(67, 15);
            LabelOfRectangles.TabIndex = 17;
            LabelOfRectangles.Text = "Rectangles:";
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ListBoxOfRectangles);
            Controls.Add(panelOfRectangles);
            Controls.Add(textBoxOfLenghtRectangle);
            Controls.Add(textBoxOfWidthRectangle);
            Controls.Add(textBoxOfYRectangle);
            Controls.Add(textBoxOfXRectangle);
            Controls.Add(textBoxlOfIDRectangle);
            Controls.Add(labelOfLenghtRectangle);
            Controls.Add(labelOfWidthRectangle);
            Controls.Add(labelOfYRectangle);
            Controls.Add(labelOfXRectangle);
            Controls.Add(labelOfIDRectangle);
            Controls.Add(labelOfSelectedRectangle);
            Controls.Add(RemoveRectanlgeButton);
            Controls.Add(AddRectangleButton);
            Controls.Add(LabelOfRectangles);
            Name = "RectanglesCollisionControl";
            Size = new Size(777, 576);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxOfRectangles;
        private Panel panelOfRectangles;
        private TextBox textBoxOfLenghtRectangle;
        private TextBox textBoxOfWidthRectangle;
        private TextBox textBoxOfYRectangle;
        private TextBox textBoxOfXRectangle;
        private TextBox textBoxlOfIDRectangle;
        private Label labelOfLenghtRectangle;
        private Label labelOfWidthRectangle;
        private Label labelOfYRectangle;
        private Label labelOfXRectangle;
        private Label labelOfIDRectangle;
        private Label labelOfSelectedRectangle;
        private Button RemoveRectanlgeButton;
        private Button AddRectangleButton;
        private Label LabelOfRectangles;
    }
}
