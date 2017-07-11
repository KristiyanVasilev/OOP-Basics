public class InvalidSongLengthException : InvalidSongException
{
    private const string DefaultMessage = ExceptionMessages.InvalidSongLengthException;
    public InvalidSongLengthException() : base(DefaultMessage)
    {
    }
    public InvalidSongLengthException(string message) : base(message)
    {
    }
}

