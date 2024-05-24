namespace Lab1.Model.Tabs
{
    partial class RectanglesControl
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
            groupBox4 = new GroupBox();
            labelID = new Label();
            TextBoxClassesRectangleID = new TextBox();
            labelY = new Label();
            labelX = new Label();
            TextBoxClassesRectangleY = new TextBox();
            TextBoxClassesRectangleX = new TextBox();
            FindRectangle = new Button();
            ColorLabel = new Label();
            WidthLabel = new Label();
            LenghtLabel = new Label();
            TextBoxClassesRectangleColor = new TextBox();
            TextBoxClassesRectangleWidth = new TextBox();
            TextBoxClassesRectangleLenght = new TextBox();
            RectangleListBox = new ListBox();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelID);
            groupBox4.Controls.Add(TextBoxClassesRectangleID);
            groupBox4.Controls.Add(labelY);
            groupBox4.Controls.Add(labelX);
            groupBox4.Controls.Add(TextBoxClassesRectangleY);
            groupBox4.Controls.Add(TextBoxClassesRectangleX);
            groupBox4.Controls.Add(FindRectangle);
            groupBox4.Controls.Add(ColorLabel);
            groupBox4.Controls.Add(WidthLabel);
            groupBox4.Controls.Add(LenghtLabel);
            groupBox4.Controls.Add(TextBoxClassesRectangleColor);
            groupBox4.Controls.Add(TextBoxClassesRectangleWidth);
            groupBox4.Controls.Add(TextBoxClassesRectangleLenght);
            groupBox4.Controls.Add(RectangleListBox);
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 284);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rectangles";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(255, 163);
            labelID.Name = "labelID";
            labelID.Size = new Size(21, 15);
            labelID.TabIndex = 13;
            labelID.Text = "ID:";
            // 
            // TextBoxClassesRectangleID
            // 
            TextBoxClassesRectangleID.Location = new Point(253, 181);
            TextBoxClassesRectangleID.Name = "TextBoxClassesRectangleID";
            TextBoxClassesRectangleID.ReadOnly = true;
            TextBoxClassesRectangleID.Size = new Size(40, 23);
            TextBoxClassesRectangleID.TabIndex = 12;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(197, 163);
            labelY.Name = "labelY";
            labelY.Size = new Size(17, 15);
            labelY.TabIndex = 11;
            labelY.Text = "Y:";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(135, 163);
            labelX.Name = "labelX";
            labelX.Size = new Size(17, 15);
            labelX.TabIndex = 10;
            labelX.Text = "X:";
            // 
            // TextBoxClassesRectangleY
            // 
            TextBoxClassesRectangleY.Location = new Point(195, 181);
            TextBoxClassesRectangleY.Name = "TextBoxClassesRectangleY";
            TextBoxClassesRectangleY.ReadOnly = true;
            TextBoxClassesRectangleY.Size = new Size(40, 23);
            TextBoxClassesRectangleY.TabIndex = 9;
            // 
            // TextBoxClassesRectangleX
            // 
            TextBoxClassesRectangleX.Location = new Point(135, 181);
            TextBoxClassesRectangleX.Name = "TextBoxClassesRectangleX";
            TextBoxClassesRectangleX.ReadOnly = true;
            TextBoxClassesRectangleX.Size = new Size(40, 23);
            TextBoxClassesRectangleX.TabIndex = 8;
            // 
            // FindRectangle
            // 
            FindRectangle.Location = new Point(160, 228);
            FindRectangle.Name = "FindRectangle";
            FindRectangle.Size = new Size(75, 23);
            FindRectangle.TabIndex = 7;
            FindRectangle.Text = "Find";
            FindRectangle.UseVisualStyleBackColor = true;
            FindRectangle.Click += FindRectangle_Click;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(135, 110);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(39, 15);
            ColorLabel.TabIndex = 6;
            ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(135, 66);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(42, 15);
            WidthLabel.TabIndex = 5;
            WidthLabel.Text = "Width:";
            // 
            // LenghtLabel
            // 
            LenghtLabel.AutoSize = true;
            LenghtLabel.Location = new Point(135, 22);
            LenghtLabel.Name = "LenghtLabel";
            LenghtLabel.Size = new Size(47, 15);
            LenghtLabel.TabIndex = 4;
            LenghtLabel.Text = "Lenght:";
            // 
            // TextBoxClassesRectangleColor
            // 
            TextBoxClassesRectangleColor.Location = new Point(135, 128);
            TextBoxClassesRectangleColor.Name = "TextBoxClassesRectangleColor";
            TextBoxClassesRectangleColor.Size = new Size(100, 23);
            TextBoxClassesRectangleColor.TabIndex = 3;
            // 
            // TextBoxClassesRectangleWidth
            // 
            TextBoxClassesRectangleWidth.Location = new Point(135, 84);
            TextBoxClassesRectangleWidth.Name = "TextBoxClassesRectangleWidth";
            TextBoxClassesRectangleWidth.Size = new Size(100, 23);
            TextBoxClassesRectangleWidth.TabIndex = 2;
            TextBoxClassesRectangleWidth.TextChanged += TextBoxClassesRectangleWidth_TextChanged;
            // 
            // TextBoxClassesRectangleLenght
            // 
            TextBoxClassesRectangleLenght.Location = new Point(135, 40);
            TextBoxClassesRectangleLenght.Name = "TextBoxClassesRectangleLenght";
            TextBoxClassesRectangleLenght.Size = new Size(100, 23);
            TextBoxClassesRectangleLenght.TabIndex = 1;
            TextBoxClassesRectangleLenght.TextChanged += TextBoxClassesRectangleLenght_TextChanged;
            // 
            // RectangleListBox
            // 
            RectangleListBox.FormattingEnabled = true;
            RectangleListBox.ItemHeight = 15;
            RectangleListBox.Location = new Point(0, 22);
            RectangleListBox.Name = "RectangleListBox";
            RectangleListBox.Size = new Size(120, 229);
            RectangleListBox.TabIndex = 0;
            RectangleListBox.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            // 
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Name = "RectanglesControl";
            Size = new Size(319, 290);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Label labelID;
        private TextBox TextBoxClassesRectangleID;
        private Label labelY;
        private Label labelX;
        private TextBox TextBoxClassesRectangleY;
        private TextBox TextBoxClassesRectangleX;
        private Button FindRectangle;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LenghtLabel;
        private TextBox TextBoxClassesRectangleColor;
        private TextBox TextBoxClassesRectangleWidth;
        private TextBox TextBoxClassesRectangleLenght;
        private ListBox RectangleListBox;
    }
}
