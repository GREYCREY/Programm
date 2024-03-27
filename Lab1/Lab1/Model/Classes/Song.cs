     class Song
    {
        private string _name;
        private int _releaseYear;
        private string _album;
        private string SongName
        {
            get { return _name; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _name = value;
            }
        }
        private int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value<1900 && value > 2024) throw new ArgumentException();
                _releaseYear = value;
            }
        }
        private string Album
        {
            get { return _album; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _album = value;
            }
        }
        public Song()
        {
            SongName = "running shoes";
            ReleaseYear = 2024;
            Album = "eve";

        }
        public Song(string name, int releaseYear, string album)
        {
            SongName = name;
            ReleaseYear = releaseYear;
            Album = album;

        }
    }

