﻿namespace Lab1
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
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            LenghtLabel = new Label();
            WidthLabel = new Label();
            ColorLabel = new Label();
            FindRectangle = new Button();
            tabPage1.SuspendLayout();
            EnumsTabs.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(EnumsTabs);
            tabPage1.Controls.Add(tabPage2);
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
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1491, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(FindRectangle);
            groupBox4.Controls.Add(ColorLabel);
            groupBox4.Controls.Add(WidthLabel);
            groupBox4.Controls.Add(LenghtLabel);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(listBox1);
            groupBox4.Location = new Point(8, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 284);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rectangles";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 229);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(135, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
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
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(135, 66);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(42, 15);
            WidthLabel.TabIndex = 5;
            WidthLabel.Text = "Width:";
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
            // FindRectangle
            // 
            FindRectangle.Location = new Point(160, 228);
            FindRectangle.Name = "FindRectangle";
            FindRectangle.Size = new Size(75, 23);
            FindRectangle.TabIndex = 7;
            FindRectangle.Text = "Find";
            FindRectangle.UseVisualStyleBackColor = true;
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
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private Label WidthLabel;
        private Label LenghtLabel;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label ColorLabel;
        private Button FindRectangle;
    }
}
