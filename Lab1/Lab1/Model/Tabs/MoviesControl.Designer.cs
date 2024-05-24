namespace Lab1.Model.Tabs
{
    partial class MoviesControl
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(228, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TextBoxClassesMovieRating
            // 
            TextBoxClassesMovieRating.Location = new Point(129, 201);
            TextBoxClassesMovieRating.Name = "TextBoxClassesMovieRating";
            TextBoxClassesMovieRating.Size = new Size(270, 23);
            TextBoxClassesMovieRating.TabIndex = 22;
            TextBoxClassesMovieRating.TextChanged += TextBoxClassesMovieRating_TextChanged;
            // 
            // TextBoxClassesMovieGenre
            // 
            TextBoxClassesMovieGenre.Location = new Point(129, 153);
            TextBoxClassesMovieGenre.Name = "TextBoxClassesMovieGenre";
            TextBoxClassesMovieGenre.Size = new Size(270, 23);
            TextBoxClassesMovieGenre.TabIndex = 21;
            TextBoxClassesMovieGenre.TextChanged += TextBoxClassesMovieGenre_TextChanged;
            // 
            // TextBoxClassesMovieYearOfIssue
            // 
            TextBoxClassesMovieYearOfIssue.Location = new Point(129, 109);
            TextBoxClassesMovieYearOfIssue.Name = "TextBoxClassesMovieYearOfIssue";
            TextBoxClassesMovieYearOfIssue.Size = new Size(270, 23);
            TextBoxClassesMovieYearOfIssue.TabIndex = 20;
            TextBoxClassesMovieYearOfIssue.TextChanged += TextBoxClassesMovieYearOfIssue_TextChanged;
            // 
            // TextBoxClassesMovieTime
            // 
            TextBoxClassesMovieTime.Location = new Point(129, 65);
            TextBoxClassesMovieTime.Name = "TextBoxClassesMovieTime";
            TextBoxClassesMovieTime.Size = new Size(270, 23);
            TextBoxClassesMovieTime.TabIndex = 19;
            TextBoxClassesMovieTime.TextChanged += TextBoxClassesMovieTime_TextChanged;
            // 
            // TextBoxClassesMovieName
            // 
            TextBoxClassesMovieName.Location = new Point(129, 21);
            TextBoxClassesMovieName.Name = "TextBoxClassesMovieName";
            TextBoxClassesMovieName.Size = new Size(270, 23);
            TextBoxClassesMovieName.TabIndex = 18;
            TextBoxClassesMovieName.TextChanged += TextBoxClassesMovieName_TextChanged;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(129, 179);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(44, 15);
            RatingLabel.TabIndex = 17;
            RatingLabel.Text = "Rating:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(129, 135);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(41, 15);
            GenreLabel.TabIndex = 16;
            GenreLabel.Text = "Genre:";
            // 
            // YearOfIssueLabel
            // 
            YearOfIssueLabel.AutoSize = true;
            YearOfIssueLabel.Location = new Point(129, 91);
            YearOfIssueLabel.Name = "YearOfIssueLabel";
            YearOfIssueLabel.Size = new Size(75, 15);
            YearOfIssueLabel.TabIndex = 15;
            YearOfIssueLabel.Text = "Year of Issue:";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(129, 47);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(36, 15);
            TimeLabel.TabIndex = 14;
            TimeLabel.Text = "Time:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(129, 3);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 13;
            NameLabel.Text = "Name:";
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 15;
            MovieListBox.Location = new Point(3, 0);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(120, 304);
            MovieListBox.TabIndex = 12;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(TextBoxClassesMovieRating);
            Controls.Add(TextBoxClassesMovieGenre);
            Controls.Add(TextBoxClassesMovieYearOfIssue);
            Controls.Add(TextBoxClassesMovieTime);
            Controls.Add(TextBoxClassesMovieName);
            Controls.Add(RatingLabel);
            Controls.Add(GenreLabel);
            Controls.Add(YearOfIssueLabel);
            Controls.Add(TimeLabel);
            Controls.Add(NameLabel);
            Controls.Add(MovieListBox);
            Name = "MoviesControl";
            Size = new Size(405, 314);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TextBoxClassesMovieRating;
        private TextBox TextBoxClassesMovieGenre;
        private TextBox TextBoxClassesMovieYearOfIssue;
        private TextBox TextBoxClassesMovieTime;
        private TextBox TextBoxClassesMovieName;
        private Label RatingLabel;
        private Label GenreLabel;
        private Label YearOfIssueLabel;
        private Label TimeLabel;
        private Label NameLabel;
        private ListBox MovieListBox;
    }
}
