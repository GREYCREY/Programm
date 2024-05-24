using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Model.Tabs
{
    public partial class MoviesControl : UserControl
    {
        public MoviesControl()
        {
            InitializeComponent();
            
            Random random = new Random();
            string[] movieTitles = new string[5] { "Dune", "Dune2", "Oppenhaimer", "Barbie", "Terminator" };

            for (int i = 0; i < 5; i++)
            {
                Movie movie = new Movie(movieTitles[i], random.Next(60, 300), random.Next(1900, 2025), Genre.Horror, Math.Round(random.NextDouble() * 10, 1));
                _movie[i] = movie;
            }
            MovieListBox.Items.AddRange(_movie);

        }
        Movie[] _movie = new Movie[5];
        Movie _currentMovie;
        private Movie FindMovieWithMaxRating()
        {
            Movie movie = _movie[0];
            double MaxRating = _movie[0].Raiting;
            foreach (Movie m in _movie)
            {
                if (m.Raiting > MaxRating)
                {
                    MaxRating = m.Raiting;
                    movie = m;
                }
            }
            return movie;

        }
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedItem == null) { return; }
            _currentMovie = (Movie)MovieListBox.SelectedItem;
            TextBoxClassesMovieName.Text = _currentMovie.Name.ToString();
            TextBoxClassesMovieTime.Text = _currentMovie.TimeInMinutes.ToString();
            TextBoxClassesMovieYearOfIssue.Text = _currentMovie.YearOfIssue.ToString();
            TextBoxClassesMovieGenre.Text = _currentMovie.GenreOfMovie.ToString();
            TextBoxClassesMovieRating.Text = _currentMovie.Raiting.ToString();

        }
        private void TextBoxClassesMovieName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesMovieName.BackColor = System.Drawing.Color.White;
                string Name = TextBoxClassesMovieName.Text;
                _currentMovie.Name = Name;
            }
            catch (Exception)
            {
                TextBoxClassesMovieName.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxClassesMovieTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesMovieTime.BackColor = System.Drawing.Color.White;
                int Duration = int.Parse(TextBoxClassesMovieTime.Text);
                _currentMovie.TimeInMinutes = Duration;
            }
            catch (Exception)
            {
                TextBoxClassesMovieTime.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxClassesMovieYearOfIssue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesMovieYearOfIssue.BackColor = System.Drawing.Color.White;
                int Release = int.Parse(TextBoxClassesMovieYearOfIssue.Text);
                _currentMovie.YearOfIssue = Release;
            }
            catch (Exception)
            {
                TextBoxClassesMovieYearOfIssue.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxClassesMovieGenre_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            string genre = TextBoxClassesMovieGenre.Text;
            if (TryGetEnumValue<Genre>(genre, out Genre value))
            {
                _currentMovie.GenreOfMovie = value;
                TextBoxClassesMovieGenre.BackColor = System.Drawing.Color.White;
            }
            else
            {
                TextBoxClassesMovieGenre.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxClassesMovieRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesMovieRating.BackColor = System.Drawing.Color.White;
                double Rating = double.Parse(TextBoxClassesMovieRating.Text);
                _currentMovie.Raiting = Rating;
            }
            catch (Exception)
            {
                TextBoxClassesMovieRating.BackColor = System.Drawing.Color.LightPink;
            }
        }
        static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Movie movie = FindMovieWithMaxRating();
            MovieListBox.SelectedItem = movie;

        }
    }
}
