namespace Lab1.Model.Tabs
{
    partial class WeekDayControl
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
            label1 = new Label();
            ValueForParsingTextBox = new TextBox();
            ButtonParsing = new Button();
            ParseAnswerLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 6);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 9;
            label1.Text = "Type value for parsing:";
            // 
            // ValueForParsingTextBox
            // 
            ValueForParsingTextBox.Location = new Point(0, 24);
            ValueForParsingTextBox.Name = "ValueForParsingTextBox";
            ValueForParsingTextBox.Size = new Size(196, 23);
            ValueForParsingTextBox.TabIndex = 10;
            ValueForParsingTextBox.TextChanged += ValueForParsingTextBox_TextChanged;
            // 
            // ButtonParsing
            // 
            ButtonParsing.Location = new Point(214, 24);
            ButtonParsing.Name = "ButtonParsing";
            ButtonParsing.Size = new Size(75, 23);
            ButtonParsing.TabIndex = 11;
            ButtonParsing.Text = "Parse";
            ButtonParsing.UseVisualStyleBackColor = true;
            ButtonParsing.Click += WeekDayParse;
            // 
            // ParseAnswerLabel
            // 
            ParseAnswerLabel.AutoSize = true;
            ParseAnswerLabel.Location = new Point(52, 67);
            ParseAnswerLabel.Name = "ParseAnswerLabel";
            ParseAnswerLabel.Size = new Size(0, 15);
            ParseAnswerLabel.TabIndex = 12;
            // 
            // WeekDayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ParseAnswerLabel);
            Controls.Add(label1);
            Controls.Add(ValueForParsingTextBox);
            Controls.Add(ButtonParsing);
            Name = "WeekDayControl";
            Size = new Size(294, 97);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ValueForParsingTextBox;
        private Button ButtonParsing;
        private Label ParseAnswerLabel;
    }
}
