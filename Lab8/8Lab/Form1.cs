using System.Text.Json;

namespace _8Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenreComboBox.Items.AddRange(Enum.GetNames(typeof(Genre)));
            _song.OrderBy(s => s.Author).ThenBy(s => s.Title).ToList();

        }
        private static List<Songs> _song = new List<Songs>();
        private static Songs _currentSong = null;
        private void AddSongsButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string author = AuthorTextBox.Text;
            int duration = Convert.ToInt32(DurationTextBox.Text);

            Genre genre = (Genre)Enum.Parse(typeof(Genre), GenreComboBox.SelectedItem.ToString());
            Songs newSong = new Songs(title, author, genre, duration);
            _song.Insert(0, newSong);
            _song = Write(_song);
        }
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MusicListBox.SelectedIndex < 0)
            {

                TitleTextBox.Clear();
                AuthorTextBox.Clear();
                GenreComboBox.SelectedIndex = -1;
                DurationTextBox.Clear();
            }
            else
            {
                TitleTextBox.Enabled = true;
                AuthorTextBox.Enabled = true;
                GenreComboBox.Enabled = true;

                _currentSong = _song[MusicListBox.SelectedIndex];

                TitleTextBox.Text = _currentSong.Title;
                AuthorTextBox.Text = _currentSong.Author;
                GenreComboBox.Text = _currentSong.SongGenre.ToString();
                DurationTextBox.Text = _currentSong.Duration.ToString();
            }
        }
        private void ChangeTextElemListBoxInstitution()
        {
            MusicListBox.Items[MusicListBox.SelectedIndex] = _song[MusicListBox.SelectedIndex].Title;
        }
        private void ChangeSongButton_Click(object sender, EventArgs e)
        {

            _currentSong.Title = TitleTextBox.Text;
            _currentSong.Author = AuthorTextBox.Text;
            GenreComboBox.SelectedItem = _currentSong.SongGenre.ToString();
            _currentSong.Duration = Convert.ToInt32(DurationTextBox.Text);
            ChangeTextElemListBoxInstitution();
            MusicListBox.Sorted = true;
            _song = Write(_song);
        }
        private void DeleteSongButton_Click(object sender, EventArgs e)
        {
            if (MusicListBox.SelectedIndex < 0) return;
            _song.RemoveAt(MusicListBox.SelectedIndex);
            MusicListBox.Items.RemoveAt(MusicListBox.SelectedIndex);

            _song = Write(_song);
        }
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitleTextBox.Text) || TitleTextBox.Text.Count() > 50)
            {
                ChangeSongButton.Enabled = false;
                return;
            }
            ChangeSongButton.Enabled = true;
        }
        private List<Songs> Write(List<Songs> list)
        {
            _song.OrderBy(s => s.Author).ThenBy(s => s.Title).ToList();
            MusicListBox.Items.Clear();

            foreach (Songs song in _song)
            {
                MusicListBox.Items.Add($"{song.Author} --> {song.Title}");
            }
            return list;
        }
        public void SaveData()
        {
            string path = Environment.CurrentDirectory + @"\data.txt";
            string data = JsonSerializer.Serialize(_song);

            File.WriteAllText(path, data);
        }
        public void LoadData()
        {
            string path = Environment.CurrentDirectory + @"\data.txt";

            if (!File.Exists(path)) return;

            string data = File.ReadAllText(path);

            _song = JsonSerializer.Deserialize<List<Songs>>(data);

            _song = Write(_song);
        }



        private void groupBoxChanging_Enter(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}
