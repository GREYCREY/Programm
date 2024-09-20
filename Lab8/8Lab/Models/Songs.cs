public class Songs
{
	private string _title;
	private string _author;
	private int _duration;
	private Genre _genre;
	public string Title
	{
		get { return _title; }
		set { SongsValidator.LengthValidator(0, 50, value); _title = value; }
	}
	public string Author
	{
		get { return _author; }
		set { SongsValidator.LengthValidator(0, 50, value); _author = value; }
	}
	
	public Genre SongGenre { get { return _genre; } set { _genre = value; } }
	public int Duration
	{
		get { return _duration; }
		set { SongsValidator.DurationValidator(0, 7200, value); _duration = value; }
	}
	public Songs() { }
	public Songs(string songTitle, string songAuthor,  Genre songGenre, int songDuration)
	{
		_title = songTitle;
		_author = songAuthor;
		_genre = songGenre;
		_duration = songDuration;
	}
	

}