namespace _8Lab
{
    partial class Form1
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
            ChangeSongButton = new Button();
            AddSongsButton = new Button();
            GenreComboBox = new ComboBox();
            groupBoxChanging = new GroupBox();
            DurationLabel = new Label();
            GenreLabel = new Label();
            AuthorLabel = new Label();
            TitleLabel = new Label();
            DurationTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            TitleTextBox = new TextBox();
            MusicListBox = new ListBox();
            DeleteSongButton = new Button();
            groupBoxChanging.SuspendLayout();
            SuspendLayout();
            // 
            // ChangeSongButton
            // 
            ChangeSongButton.Location = new Point(120, 273);
            ChangeSongButton.Margin = new Padding(3, 2, 3, 2);
            ChangeSongButton.Name = "ChangeSongButton";
            ChangeSongButton.Size = new Size(82, 22);
            ChangeSongButton.TabIndex = 9;
            ChangeSongButton.Text = "Change";
            ChangeSongButton.UseVisualStyleBackColor = true;
            ChangeSongButton.Click += ChangeSongButton_Click;
            // 
            // AddSongsButton
            // 
            AddSongsButton.Location = new Point(12, 273);
            AddSongsButton.Margin = new Padding(3, 2, 3, 2);
            AddSongsButton.Name = "AddSongsButton";
            AddSongsButton.Size = new Size(82, 22);
            AddSongsButton.TabIndex = 8;
            AddSongsButton.Text = "Add";
            AddSongsButton.UseVisualStyleBackColor = true;
            AddSongsButton.Click += AddSongsButton_Click;
            // 
            // GenreComboBox
            // 
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(58, 113);
            GenreComboBox.Margin = new Padding(3, 2, 3, 2);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(133, 23);
            GenreComboBox.TabIndex = 4;
            // 
            // groupBoxChanging
            // 
            groupBoxChanging.Controls.Add(DurationLabel);
            groupBoxChanging.Controls.Add(GenreLabel);
            groupBoxChanging.Controls.Add(AuthorLabel);
            groupBoxChanging.Controls.Add(TitleLabel);
            groupBoxChanging.Controls.Add(DurationTextBox);
            groupBoxChanging.Controls.Add(AuthorTextBox);
            groupBoxChanging.Controls.Add(TitleTextBox);
            groupBoxChanging.Controls.Add(GenreComboBox);
            groupBoxChanging.Location = new Point(317, 23);
            groupBoxChanging.Margin = new Padding(3, 2, 3, 2);
            groupBoxChanging.Name = "groupBoxChanging";
            groupBoxChanging.Padding = new Padding(3, 2, 3, 2);
            groupBoxChanging.Size = new Size(407, 218);
            groupBoxChanging.TabIndex = 11;
            groupBoxChanging.TabStop = false;
            groupBoxChanging.Text = "Select Instruction:";
            groupBoxChanging.Enter += groupBoxChanging_Enter;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(0, 151);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(56, 15);
            DurationLabel.TabIndex = 11;
            DurationLabel.Text = "Duration:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(11, 113);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(41, 15);
            GenreLabel.TabIndex = 10;
            GenreLabel.Text = "Genre:";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(5, 77);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(47, 15);
            AuthorLabel.TabIndex = 9;
            AuthorLabel.Text = "Author:";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(6, 41);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(32, 15);
            TitleLabel.TabIndex = 8;
            TitleLabel.Text = "Title:";
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(58, 148);
            DurationTextBox.Margin = new Padding(3, 2, 3, 2);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(124, 23);
            DurationTextBox.TabIndex = 7;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(58, 74);
            AuthorTextBox.Margin = new Padding(3, 2, 3, 2);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(342, 23);
            AuthorTextBox.TabIndex = 6;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(57, 33);
            TitleTextBox.Margin = new Padding(3, 2, 3, 2);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(343, 23);
            TitleTextBox.TabIndex = 5;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // MusicListBox
            // 
            MusicListBox.FormattingEnabled = true;
            MusicListBox.ItemHeight = 15;
            MusicListBox.Location = new Point(12, 11);
            MusicListBox.Margin = new Padding(3, 2, 3, 2);
            MusicListBox.Name = "MusicListBox";
            MusicListBox.Size = new Size(299, 259);
            MusicListBox.TabIndex = 10;
            MusicListBox.SelectedIndexChanged += NotesListBox_SelectedIndexChanged;
            // 
            // DeleteSongButton
            // 
            DeleteSongButton.Location = new Point(228, 273);
            DeleteSongButton.Margin = new Padding(3, 2, 3, 2);
            DeleteSongButton.Name = "DeleteSongButton";
            DeleteSongButton.Size = new Size(82, 22);
            DeleteSongButton.TabIndex = 12;
            DeleteSongButton.Text = "Delete";
            DeleteSongButton.UseVisualStyleBackColor = true;
            DeleteSongButton.Click += DeleteSongButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 318);
            Controls.Add(ChangeSongButton);
            Controls.Add(AddSongsButton);
            Controls.Add(groupBoxChanging);
            Controls.Add(MusicListBox);
            Controls.Add(DeleteSongButton);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBoxChanging.ResumeLayout(false);
            groupBoxChanging.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ChangeSongButton;
        private Button AddSongsButton;
        private ComboBox GenreComboBox;
        private GroupBox groupBoxChanging;
        private Label DurationLabel;
        private Label GenreLabel;
        private Label AuthorLabel;
        private Label TitleLabel;
        private TextBox DurationTextBox;
        private TextBox AuthorTextBox;
        private TextBox TitleTextBox;
        private ListBox MusicListBox;
        private Button DeleteSongButton;
    }
}
