/// <summary>
/// Представляет класс песни.
/// </summary>  
class Song
     {
        private string _name;
        private int _releaseYear;
        private string _album;
        /// <summary>
        /// Возвращает или задает название песни.
        /// </summary>
        private string SongName
        {
            get { return _name; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает или задает год выпуска песни.
        /// </summary>
        private int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                Validator.AssertValueInRange(value, 1900, 2024);
                _releaseYear = value;
            }
        }
        /// <summary>
        /// Возвращает или задает название альбома, в котором содержится песня.
        /// </summary>
        private string Album
        {
            get { return _album; }
            set
            {
                if (value.Length == 0) throw new ArgumentException();
                _album = value;
            }
        }
        /// <summary>
        /// Инициализирует новый экземпляр класса Song со значениями по умолчанию.
        /// </summary>
        public Song()
        {
            SongName = "running shoes";
            ReleaseYear = 2024;
            Album = "eve";

        }
        /// <summary>
        /// Инициализирует новый экземпляр класса Song с указанными значениями.
        /// </summary>
        /// <param name="name">Название песни</param>
        /// <param name="releaseYear">Год выпуска песни</param>
        /// <param name="album">Название альбома</param>
        public Song(string name, int releaseYear, string album)
        {
            SongName = name;
            ReleaseYear = releaseYear;
            Album = album;

        }
     }

