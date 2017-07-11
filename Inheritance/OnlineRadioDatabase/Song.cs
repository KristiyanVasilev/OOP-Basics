using OnlineRadioDatabase.Exceptions;

public class Song
{
    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;
    private string lenght;

    public Song(string artistName, string songName, string lenght)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Lenght = lenght;
    }

    public int Seconds
    {
        get { return this.seconds; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new InvalidSongSecondsException();
            }

            this.seconds = value;
        }
    }
    public int Minutes
    {
        get { return this.minutes; }
        set
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException();
            }

            this.minutes = value;
        }
    }
    public string SongName
    {
        get { return songName; }
        set
        {
            if (value == null || value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException();
            }
            songName = value;
        }
    }

    public string ArtistName
    {
        get { return artistName; }
        set
        {
            if (value == null || value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException();
            }
            artistName = value;
        }
    }
    public string Lenght
    {
        set
        {
            var tokens = value.Split(':');
            int minutes;
            int seconds;
            try
            {
                minutes = int.Parse(tokens[0]);
                seconds = int.Parse(tokens[1]);
            }
            catch (System.Exception)
            {
                throw new InvalidSongLengthException();
            }
            this.Minutes = minutes;
            this.Seconds = seconds;
            this.lenght = value;
        }
    }
}
