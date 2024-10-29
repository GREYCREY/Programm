namespace Lab1.Model.Tabs
{
    partial class SeasonControl
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
            ChooseSeasonLabel = new Label();
            SeasoncomboBox = new ComboBox();
            GoButton = new Button();
            SuspendLayout();
            // 
            // ChooseSeasonLabel
            // 
            ChooseSeasonLabel.AutoSize = true;
            ChooseSeasonLabel.Location = new Point(3, 11);
            ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            ChooseSeasonLabel.Size = new Size(89, 15);
            ChooseSeasonLabel.TabIndex = 13;
            ChooseSeasonLabel.Text = "Choose season:";
            ChooseSeasonLabel.Click += SeasonSwitch;
            // 
            // SeasoncomboBox
            // 
            SeasoncomboBox.FormattingEnabled = true;
            SeasoncomboBox.Items.AddRange(new object[] { "Spring", "Summer", "Autumn", "Winter" });
            SeasoncomboBox.Location = new Point(3, 29);
            SeasoncomboBox.Name = "SeasoncomboBox";
            SeasoncomboBox.Size = new Size(121, 23);
            SeasoncomboBox.TabIndex = 14;
            SeasoncomboBox.SelectedIndexChanged += SeasonSwitch;
            SeasoncomboBox.Click += SeasonSwitch;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(147, 29);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 23);
            GoButton.TabIndex = 15;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += SeasonSwitch;
            // 
            // SeasonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChooseSeasonLabel);
            Controls.Add(SeasoncomboBox);
            Controls.Add(GoButton);
            Name = "SeasonControl";
            Size = new Size(231, 64);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChooseSeasonLabel;
        private ComboBox SeasoncomboBox;
        private Button GoButton;
    }
}
