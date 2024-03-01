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
            ChooseSeasonLabel = new Label();
            SeasoncomboBox = new ComboBox();
            GoButton = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            ValueForParsingTextBox = new TextBox();
            ButtonParsing = new Button();
            ParseAnswerLabel = new Label();
            groupBox1 = new GroupBox();
            IntValueTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            ChooseEnumerationLabel = new Label();
            ChooseValueLabel = new Label();
            IntValueLabel = new Label();
            tabPage1.SuspendLayout();
            EnumsTabs.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(EnumsTabs);
            tabPage1.Dock = DockStyle.Fill;
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.SelectedIndex = 0;
            tabPage1.Size = new Size(1499, 664);
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
            EnumsTabs.Size = new Size(1491, 636);
            EnumsTabs.TabIndex = 0;
            EnumsTabs.Text = "Enums";
            EnumsTabs.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ChooseSeasonLabel);
            groupBox3.Controls.Add(SeasoncomboBox);
            groupBox3.Controls.Add(GoButton);
            groupBox3.Location = new Point(398, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 135);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Season Handle";
            
            // 
            // ChooseSeasonLabel
            // 
            ChooseSeasonLabel.AutoSize = true;
            ChooseSeasonLabel.Location = new Point(6, 57);
            ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            ChooseSeasonLabel.Size = new Size(89, 15);
            ChooseSeasonLabel.TabIndex = 10;
            ChooseSeasonLabel.Text = "Choose season:";
            // 
            // SeasoncomboBox
            // 
            SeasoncomboBox.FormattingEnabled = true;
            SeasoncomboBox.Items.AddRange(new object[] { "Spring", "Summer", "Autumn", "Winter" });
            SeasoncomboBox.Location = new Point(6, 75);
            SeasoncomboBox.Name = "SeasoncomboBox";
            SeasoncomboBox.Size = new Size(121, 23);
            SeasoncomboBox.TabIndex = 11;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(150, 75);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(75, 23);
            GoButton.TabIndex = 12;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += SeasonSwitch;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(ValueForParsingTextBox);
            groupBox2.Controls.Add(ButtonParsing);
            groupBox2.Controls.Add(ParseAnswerLabel);
            groupBox2.Location = new Point(14, 317);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 150);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekday Parsing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 6;
            label1.Text = "Type value for parsing:";
            // 
            // ValueForParsingTextBox
            // 
            ValueForParsingTextBox.Location = new Point(6, 75);
            ValueForParsingTextBox.Name = "ValueForParsingTextBox";
            ValueForParsingTextBox.Size = new Size(196, 23);
            ValueForParsingTextBox.TabIndex = 7;
            
            // 
            // ButtonParsing
            // 
            ButtonParsing.Location = new Point(220, 75);
            ButtonParsing.Name = "ButtonParsing";
            ButtonParsing.Size = new Size(75, 23);
            ButtonParsing.TabIndex = 8;
            ButtonParsing.Text = "Parse";
            ButtonParsing.UseVisualStyleBackColor = true;
            ButtonParsing.Click += WeekDayParse;
            // 
            // ParseAnswerLabel
            // 
            ParseAnswerLabel.AutoSize = true;
            ParseAnswerLabel.Location = new Point(45, 120);
            ParseAnswerLabel.Name = "ParseAnswerLabel";
            ParseAnswerLabel.Size = new Size(0, 15);
            ParseAnswerLabel.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IntValueTextBox);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Controls.Add(ChooseEnumerationLabel);
            groupBox1.Controls.Add(ChooseValueLabel);
            groupBox1.Controls.Add(IntValueLabel);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 305);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            IntValueTextBox.Location = new Point(370, 73);
            IntValueTextBox.Name = "IntValueTextBox";
            IntValueTextBox.Size = new Size(100, 23);
            IntValueTextBox.TabIndex = 3;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(220, 73);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(120, 94);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += valuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.BackColor = SystemColors.Window;
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Colors", "FormOfStudy", "Genre", "Season", "SmartphoneManufacturers", "WeekDay" });
            EnumsListBox.Location = new Point(6, 73);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(168, 109);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += enumsListBox_SelectedIndexChanged;
            // 
            // ChooseEnumerationLabel
            // 
            ChooseEnumerationLabel.AutoSize = true;
            ChooseEnumerationLabel.Location = new Point(6, 53);
            ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            ChooseEnumerationLabel.Size = new Size(121, 15);
            ChooseEnumerationLabel.TabIndex = 2;
            ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // ChooseValueLabel
            // 
            ChooseValueLabel.AutoSize = true;
            ChooseValueLabel.Location = new Point(220, 53);
            ChooseValueLabel.Name = "ChooseValueLabel";
            ChooseValueLabel.Size = new Size(81, 15);
            ChooseValueLabel.TabIndex = 4;
            ChooseValueLabel.Text = "Choose value:";
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(370, 53);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(55, 15);
            IntValueLabel.TabIndex = 5;
            IntValueLabel.Text = "Int value:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 664);
            Controls.Add(tabPage1);
            Name = "MainForm";
            Text = "Form1";
            tabPage1.ResumeLayout(false);
            EnumsTabs.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPage1;
        private TabPage EnumsTabs;
        private Label ChooseEnumerationLabel;
        private Label IntValueLabel;
        private Label ChooseValueLabel;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TextBox IntValueTextBox;
        private TextBox ValueForParsingTextBox;
        private Label label1;
        private Label ParseAnswerLabel;
        private Button ButtonParsing;
        private ComboBox SeasoncomboBox;
        private Label ChooseSeasonLabel;
        private Button GoButton;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
    }
}
