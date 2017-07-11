using System;

public class InvalidSongException : ArgumentException
{
    private const string DefaultMessage = ExceptionMessages.InvalidSongException;

    public InvalidSongException() : base(DefaultMessage)
    {

    }
    public InvalidSongException(string message) : base(message)
    {

    }
}

