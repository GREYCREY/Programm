using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{

    public partial class MainForm : Form
    {
        Rectangle[] _rectangles = new Rectangle[5];
        Rectangle _currentRectangle;
        Movie[] _movie = new Movie[5];
        Movie _currentMovie;
        public MainForm()
        {
            InitializeComponent();
            Random random = new Random();
            string[] movieTitles = new string[5] { "Dune", "Dune2", "Oppenhaimer", "Barbie", "Terminator" };
            for (int i = 0; i < 5; i++)
            {
                Rectangle rectangle = new Rectangle(Math.Round(random.NextDouble() * 10.0, 1), Math.Round(random.NextDouble() * 10.0, 1), Colors.Red,
                0, 0);
                _rectangles[i] = rectangle;
            }
            RectangleListBox.Items.AddRange(_rectangles);
            for (int i = 0; i < 5; i++)
            {
                Movie movie = new Movie(movieTitles[i], random.Next(60, 300), random.Next(1900, 2025), Genre.Horror, Math.Round(random.NextDouble() * 10, 1));
                _movie[i] = movie;
            }
            MovieListBox.Items.AddRange(_movie);

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

        private void SeasonSwitch(object sender, EventArgs e)
        {
            switch (SeasoncomboBox.SelectedIndex)
            {
                case 0:
                    EnumsTabs.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case 1:
                    MessageBox.Show("Ура!Солнце!");
                    break;
                case 2:
                    EnumsTabs.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case 3:
                    MessageBox.Show("Бррр!Холодно!");
                    break;
            }
        }
        private Rectangle FindRectangleWithMaxWidth()
        {
            Rectangle rectangle = _rectangles[0];
            double MaxWidth = _rectangles[0].Wight;
            foreach (Rectangle r in _rectangles)
            {
                if (r.Wight > MaxWidth)
                {
                    MaxWidth = r.Wight;
                    rectangle = r;
                }
            }
            return rectangle;

        }
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
        private void WeekDayParse(object sender, EventArgs e)
        {
            Weekday weekday;
            var temp = ValueForParsingTextBox.Text;
            int examination;
            bool isInt;
            if (!(temp == "") && !(temp == " "))
            {
                if (Enum.TryParse(temp, out weekday))
                {
                    ParseAnswerLabel.Text = $"День недели:({weekday} = {(int)weekday})";
                }
                else
                {
                    ParseAnswerLabel.Text = "Некорректно введены данные!";
                }
                isInt = int.TryParse(temp, out examination);
                if (isInt)
                {
                    ParseAnswerLabel.Text = "Введите название дня текстом.";
                }
            }
            else
            {
                ParseAnswerLabel.Text = $"Некорректно введены данные.";
            }
        }
        private void enumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedIndex)
            {
                case 0:
                    FillingValuesListBox<Colors>();
                    break;
                case 1:
                    FillingValuesListBox<FormOfStudy>();
                    break;
                case 2:
                    FillingValuesListBox<Genre>();
                    break;
                case 3:
                    FillingValuesListBox<Season>();
                    break;
                case 4:
                    FillingValuesListBox<SmartphoneManufacturers>();
                    break;
                case 5:
                    FillingValuesListBox<Weekday>();
                    break;
            }
        }
        private void valuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Clear();
            IntValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void FillingValuesListBox<T>()
        {
            Type enumType = typeof(T);
            foreach (var i in Enum.GetValues(enumType))
            {
                ValuesListBox.Items.Add(i);
            }
        }


        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedItem == null) { return; }
            _currentRectangle = (Rectangle)RectangleListBox.SelectedItem;
            TextBoxClassesRectangleWidth.Text = _currentRectangle.Wight.ToString();
            TextBoxClassesRectangleLenght.Text = _currentRectangle.Lenght.ToString();
            TextBoxClassesRectangleColor.Text = _currentRectangle.ColorOfRectangle.ToString();
            TextBoxClassesRectangleX.Text = _currentRectangle.CenterOfRectangle.X.ToString();
            TextBoxClassesRectangleY.Text = _currentRectangle.CenterOfRectangle.Y.ToString();
            TextBoxClassesRectangleID.Text = _currentRectangle.ID.ToString();



        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ColorLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            if (TryGetEnumValue<Colors>(TextBoxClassesRectangleColor.Text, out Colors value))
            {
                _currentRectangle.ColorOfRectangle = value;
                TextBoxClassesRectangleColor.BackColor = System.Drawing.Color.White;
            }
            else
            {
                TextBoxClassesRectangleColor.BackColor = System.Drawing.Color.Pink;
            }
        }

        private void TextBoxClassesRectangleWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesRectangleWidth.BackColor = System.Drawing.Color.White;
                double wight = double.Parse(TextBoxClassesRectangleWidth.Text);
                _currentRectangle.Wight = wight;
            }
            catch
            {
                TextBoxClassesRectangleWidth.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void TextBoxClassesRectangleLenght_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesRectangleLenght.BackColor = System.Drawing.Color.White;
                double lenght = double.Parse(TextBoxClassesRectangleLenght.Text);
                _currentRectangle.Wight = lenght;
            }
            catch
            {
                TextBoxClassesRectangleLenght.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = FindRectangleWithMaxWidth();
            RectangleListBox.SelectedItem = rectangle;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Movie movie = FindMovieWithMaxRating();
            MovieListBox.SelectedItem = movie;

        }

        private void TextBoxClassesRectangleY_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
