public class InvalidSongMinutesException : InvalidSongLengthException
{
    private const string DefaultMessage = ExceptionMessages.InvalidSongMinutesException;
    public InvalidSongMinutesException() : base(DefaultMessage)
    {
    }
}

