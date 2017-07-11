public class InvalidSongSecondsException : InvalidSongLengthException
{
    private const string DefaultMessage = ExceptionMessages.InvalidSongSecondsException;
    public InvalidSongSecondsException() : base(DefaultMessage)
    {
    }
}

