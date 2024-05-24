namespace Lab1.Model.Tabs
{
    partial class EnumsControl
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
            IntValueTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            ChooseEnumerationLabel = new Label();
            ChooseValueLabel = new Label();
            IntValueLabel = new Label();
            SuspendLayout();
            // 
            // IntValueTextBox
            // 
            IntValueTextBox.Location = new Point(367, 36);
            IntValueTextBox.Name = "IntValueTextBox";
            IntValueTextBox.Size = new Size(100, 23);
            IntValueTextBox.TabIndex = 9;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(217, 36);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(120, 94);
            ValuesListBox.TabIndex = 7;
            ValuesListBox.SelectedIndexChanged += valuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.BackColor = SystemColors.Window;
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Colors", "FormOfStudy", "Genre", "Season", "SmartphoneManufacturers", "WeekDay" });
            EnumsListBox.Location = new Point(3, 36);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(168, 109);
            EnumsListBox.TabIndex = 6;
            EnumsListBox.SelectedIndexChanged += enumsListBox_SelectedIndexChanged;
            // 
            // ChooseEnumerationLabel
            // 
            ChooseEnumerationLabel.AutoSize = true;
            ChooseEnumerationLabel.Location = new Point(3, 16);
            ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            ChooseEnumerationLabel.Size = new Size(121, 15);
            ChooseEnumerationLabel.TabIndex = 8;
            ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // ChooseValueLabel
            // 
            ChooseValueLabel.AutoSize = true;
            ChooseValueLabel.Location = new Point(217, 16);
            ChooseValueLabel.Name = "ChooseValueLabel";
            ChooseValueLabel.Size = new Size(81, 15);
            ChooseValueLabel.TabIndex = 10;
            ChooseValueLabel.Text = "Choose value:";
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(367, 16);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(55, 15);
            IntValueLabel.TabIndex = 11;
            IntValueLabel.Text = "Int value:";
            // 
            // EnumsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IntValueTextBox);
            Controls.Add(ValuesListBox);
            Controls.Add(EnumsListBox);
            Controls.Add(ChooseEnumerationLabel);
            Controls.Add(ChooseValueLabel);
            Controls.Add(IntValueLabel);
            Name = "EnumsControl";
            Size = new Size(474, 155);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IntValueTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label ChooseEnumerationLabel;
        private Label ChooseValueLabel;
        private Label IntValueLabel;
    }
}
