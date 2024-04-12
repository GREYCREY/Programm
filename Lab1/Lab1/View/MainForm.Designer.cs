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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            groupBox5 = new GroupBox();
            button1 = new Button();
            TextBoxClassesMovieRating = new TextBox();
            TextBoxClassesMovieGenre = new TextBox();
            TextBoxClassesMovieYearOfIssue = new TextBox();
            TextBoxClassesMovieTime = new TextBox();
            TextBoxClassesMovieName = new TextBox();
            RatingLabel = new Label();
            GenreLabel = new Label();
            YearOfIssueLabel = new Label();
            TimeLabel = new Label();
            NameLabel = new Label();
            MovieListBox = new ListBox();
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
            tabPage3 = new TabPage();
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
            groupBox6 = new GroupBox();
            LabelOfRectangles = new Label();
            tabPage1.SuspendLayout();
            EnumsTabs.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
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
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(828, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(TextBoxClassesMovieRating);
            groupBox5.Controls.Add(TextBoxClassesMovieGenre);
            groupBox5.Controls.Add(TextBoxClassesMovieYearOfIssue);
            groupBox5.Controls.Add(TextBoxClassesMovieTime);
            groupBox5.Controls.Add(TextBoxClassesMovieName);
            groupBox5.Controls.Add(RatingLabel);
            groupBox5.Controls.Add(GenreLabel);
            groupBox5.Controls.Add(YearOfIssueLabel);
            groupBox5.Controls.Add(TimeLabel);
            groupBox5.Controls.Add(NameLabel);
            groupBox5.Controls.Add(MovieListBox);
            groupBox5.Location = new Point(412, 16);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(408, 354);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // button1
            // 
            button1.Location = new Point(231, 312);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TextBoxClassesMovieRating
            // 
            TextBoxClassesMovieRating.Location = new Point(132, 229);
            TextBoxClassesMovieRating.Name = "TextBoxClassesMovieRating";
            TextBoxClassesMovieRating.Size = new Size(270, 23);
            TextBoxClassesMovieRating.TabIndex = 10;
            TextBoxClassesMovieRating.TextChanged += TextBoxClassesMovieRating_TextChanged;
            // 
            // TextBoxClassesMovieGenre
            // 
            TextBoxClassesMovieGenre.Location = new Point(132, 181);
            TextBoxClassesMovieGenre.Name = "TextBoxClassesMovieGenre";
            TextBoxClassesMovieGenre.Size = new Size(270, 23);
            TextBoxClassesMovieGenre.TabIndex = 9;
            TextBoxClassesMovieGenre.TextChanged += TextBoxClassesMovieGenre_TextChanged;
            // 
            // TextBoxClassesMovieYearOfIssue
            // 
            TextBoxClassesMovieYearOfIssue.Location = new Point(132, 137);
            TextBoxClassesMovieYearOfIssue.Name = "TextBoxClassesMovieYearOfIssue";
            TextBoxClassesMovieYearOfIssue.Size = new Size(270, 23);
            TextBoxClassesMovieYearOfIssue.TabIndex = 8;
            TextBoxClassesMovieYearOfIssue.TextChanged += TextBoxClassesMovieYearOfIssue_TextChanged;
            // 
            // TextBoxClassesMovieTime
            // 
            TextBoxClassesMovieTime.Location = new Point(132, 93);
            TextBoxClassesMovieTime.Name = "TextBoxClassesMovieTime";
            TextBoxClassesMovieTime.Size = new Size(270, 23);
            TextBoxClassesMovieTime.TabIndex = 7;
            TextBoxClassesMovieTime.TextChanged += TextBoxClassesMovieTime_TextChanged;
            // 
            // TextBoxClassesMovieName
            // 
            TextBoxClassesMovieName.Location = new Point(132, 49);
            TextBoxClassesMovieName.Name = "TextBoxClassesMovieName";
            TextBoxClassesMovieName.Size = new Size(270, 23);
            TextBoxClassesMovieName.TabIndex = 6;
            TextBoxClassesMovieName.TextChanged += TextBoxClassesMovieName_TextChanged;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(132, 207);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(44, 15);
            RatingLabel.TabIndex = 5;
            RatingLabel.Text = "Rating:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(132, 163);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(41, 15);
            GenreLabel.TabIndex = 4;
            GenreLabel.Text = "Genre:";
            // 
            // YearOfIssueLabel
            // 
            YearOfIssueLabel.AutoSize = true;
            YearOfIssueLabel.Location = new Point(132, 119);
            YearOfIssueLabel.Name = "YearOfIssueLabel";
            YearOfIssueLabel.Size = new Size(75, 15);
            YearOfIssueLabel.TabIndex = 3;
            YearOfIssueLabel.Text = "Year of Issue:";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(132, 75);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(36, 15);
            TimeLabel.TabIndex = 2;
            TimeLabel.Text = "Time:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(132, 31);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name:";
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 15;
            MovieListBox.Location = new Point(6, 31);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(120, 304);
            MovieListBox.TabIndex = 0;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
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
            groupBox4.Location = new Point(8, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 284);
            groupBox4.TabIndex = 0;
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
            TextBoxClassesRectangleY.TextChanged += TextBoxClassesRectangleY_TextChanged;
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
            TextBoxClassesRectangleColor.TextChanged += textBox3_TextChanged;
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
            // tabPage3
            // 
            tabPage3.Controls.Add(panelOfRectangles);
            tabPage3.Controls.Add(textBoxOfLenghtRectangle);
            tabPage3.Controls.Add(textBoxOfWidthRectangle);
            tabPage3.Controls.Add(textBoxOfYRectangle);
            tabPage3.Controls.Add(textBoxOfXRectangle);
            tabPage3.Controls.Add(textBoxlOfIDRectangle);
            tabPage3.Controls.Add(labelOfLenghtRectangle);
            tabPage3.Controls.Add(labelOfWidthRectangle);
            tabPage3.Controls.Add(labelOfYRectangle);
            tabPage3.Controls.Add(labelOfXRectangle);
            tabPage3.Controls.Add(labelOfIDRectangle);
            tabPage3.Controls.Add(labelOfSelectedRectangle);
            tabPage3.Controls.Add(RemoveRectanlgeButton);
            tabPage3.Controls.Add(AddRectangleButton);
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Controls.Add(LabelOfRectangles);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(828, 636);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rectangles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelOfRectangles
            // 
            panelOfRectangles.BorderStyle = BorderStyle.FixedSingle;
            panelOfRectangles.Location = new Point(295, 6);
            panelOfRectangles.Name = "panelOfRectangles";
            panelOfRectangles.Size = new Size(525, 565);
            panelOfRectangles.TabIndex = 15;
            // 
            // textBoxOfLenghtRectangle
            // 
            textBoxOfLenghtRectangle.Location = new Point(58, 365);
            textBoxOfLenghtRectangle.Name = "textBoxOfLenghtRectangle";
            textBoxOfLenghtRectangle.Size = new Size(100, 23);
            textBoxOfLenghtRectangle.TabIndex = 14;
            // 
            // textBoxOfWidthRectangle
            // 
            textBoxOfWidthRectangle.Location = new Point(58, 336);
            textBoxOfWidthRectangle.Name = "textBoxOfWidthRectangle";
            textBoxOfWidthRectangle.Size = new Size(100, 23);
            textBoxOfWidthRectangle.TabIndex = 13;
            // 
            // textBoxOfYRectangle
            // 
            textBoxOfYRectangle.Location = new Point(58, 307);
            textBoxOfYRectangle.Name = "textBoxOfYRectangle";
            textBoxOfYRectangle.Size = new Size(100, 23);
            textBoxOfYRectangle.TabIndex = 12;
            // 
            // textBoxOfXRectangle
            // 
            textBoxOfXRectangle.Location = new Point(58, 278);
            textBoxOfXRectangle.Name = "textBoxOfXRectangle";
            textBoxOfXRectangle.Size = new Size(100, 23);
            textBoxOfXRectangle.TabIndex = 11;
            // 
            // textBoxlOfIDRectangle
            // 
            textBoxlOfIDRectangle.Location = new Point(58, 249);
            textBoxlOfIDRectangle.Name = "textBoxlOfIDRectangle";
            textBoxlOfIDRectangle.Size = new Size(100, 23);
            textBoxlOfIDRectangle.TabIndex = 10;
            // 
            // labelOfLenghtRectangle
            // 
            labelOfLenghtRectangle.AutoSize = true;
            labelOfLenghtRectangle.Location = new Point(5, 373);
            labelOfLenghtRectangle.Name = "labelOfLenghtRectangle";
            labelOfLenghtRectangle.Size = new Size(47, 15);
            labelOfLenghtRectangle.TabIndex = 9;
            labelOfLenghtRectangle.Text = "Lenght:";
            // 
            // labelOfWidthRectangle
            // 
            labelOfWidthRectangle.AutoSize = true;
            labelOfWidthRectangle.Location = new Point(10, 344);
            labelOfWidthRectangle.Name = "labelOfWidthRectangle";
            labelOfWidthRectangle.Size = new Size(42, 15);
            labelOfWidthRectangle.TabIndex = 8;
            labelOfWidthRectangle.Text = "Width:";
            // 
            // labelOfYRectangle
            // 
            labelOfYRectangle.AutoSize = true;
            labelOfYRectangle.Location = new Point(35, 315);
            labelOfYRectangle.Name = "labelOfYRectangle";
            labelOfYRectangle.Size = new Size(17, 15);
            labelOfYRectangle.TabIndex = 7;
            labelOfYRectangle.Text = "Y:";
            // 
            // labelOfXRectangle
            // 
            labelOfXRectangle.AutoSize = true;
            labelOfXRectangle.Location = new Point(35, 286);
            labelOfXRectangle.Name = "labelOfXRectangle";
            labelOfXRectangle.Size = new Size(17, 15);
            labelOfXRectangle.TabIndex = 6;
            labelOfXRectangle.Text = "X:";
            labelOfXRectangle.Click += labelOfXRectangle_Click;
            // 
            // labelOfIDRectangle
            // 
            labelOfIDRectangle.AutoSize = true;
            labelOfIDRectangle.Location = new Point(31, 257);
            labelOfIDRectangle.Name = "labelOfIDRectangle";
            labelOfIDRectangle.Size = new Size(21, 15);
            labelOfIDRectangle.TabIndex = 5;
            labelOfIDRectangle.Text = "ID:";
            // 
            // labelOfSelectedRectangle
            // 
            labelOfSelectedRectangle.AutoSize = true;
            labelOfSelectedRectangle.Location = new Point(6, 227);
            labelOfSelectedRectangle.Name = "labelOfSelectedRectangle";
            labelOfSelectedRectangle.Size = new Size(112, 15);
            labelOfSelectedRectangle.TabIndex = 4;
            labelOfSelectedRectangle.Text = "Selected Rectangle: ";
            // 
            // RemoveRectanlgeButton
            // 
            RemoveRectanlgeButton.FlatStyle = FlatStyle.Flat;
            RemoveRectanlgeButton.Image = (Image)resources.GetObject("RemoveRectanlgeButton.Image");
            RemoveRectanlgeButton.Location = new Point(126, 163);
            RemoveRectanlgeButton.Name = "RemoveRectanlgeButton";
            RemoveRectanlgeButton.Size = new Size(32, 33);
            RemoveRectanlgeButton.TabIndex = 3;
            RemoveRectanlgeButton.UseVisualStyleBackColor = true;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.Image = (Image)resources.GetObject("AddRectangleButton.Image");
            AddRectangleButton.Location = new Point(31, 163);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(32, 33);
            AddRectangleButton.TabIndex = 2;
            AddRectangleButton.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Location = new Point(8, 42);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(281, 115);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            // 
            // LabelOfRectangles
            // 
            LabelOfRectangles.AutoSize = true;
            LabelOfRectangles.Location = new Point(6, 24);
            LabelOfRectangles.Name = "LabelOfRectangles";
            LabelOfRectangles.Size = new Size(67, 15);
            LabelOfRectangles.TabIndex = 0;
            LabelOfRectangles.Text = "Rectangles:";
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
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
        private TextBox TextBoxClassesRectangleColor;
        private TextBox TextBoxClassesRectangleWidth;
        private TextBox TextBoxClassesRectangleLenght;
        private ListBox RectangleListBox;
        private Label ColorLabel;
        private Button FindRectangle;
        private GroupBox groupBox5;
        private ListBox MovieListBox;
        private Label RatingLabel;
        private Label GenreLabel;
        private Label YearOfIssueLabel;
        private Label TimeLabel;
        private Label NameLabel;
        private Button button1;
        private TextBox TextBoxClassesMovieRating;
        private TextBox TextBoxClassesMovieGenre;
        private TextBox TextBoxClassesMovieYearOfIssue;
        private TextBox TextBoxClassesMovieTime;
        private TextBox TextBoxClassesMovieName;
        private TextBox TextBoxClassesRectangleX;
        private Label labelY;
        private Label labelX;
        private TextBox TextBoxClassesRectangleY;
        private TextBox TextBoxClassesRectangleID;
        private Label labelID;
        private TabPage tabPage3;
        private Label LabelOfRectangles;
        private GroupBox groupBox6;
        private Button AddRectangleButton;
        private Button RemoveRectanlgeButton;
        private Label labelOfLenghtRectangle;
        private Label labelOfWidthRectangle;
        private Label labelOfYRectangle;
        private Label labelOfXRectangle;
        private Label labelOfIDRectangle;
        private Label labelOfSelectedRectangle;
        private TextBox textBoxOfXRectangle;
        private TextBox textBoxlOfIDRectangle;
        private TextBox textBoxOfLenghtRectangle;
        private TextBox textBoxOfWidthRectangle;
        private TextBox textBoxOfYRectangle;
        private Panel panelOfRectangles;
    }
}
