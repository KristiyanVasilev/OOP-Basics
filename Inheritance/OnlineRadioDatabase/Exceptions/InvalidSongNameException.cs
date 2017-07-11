using System;

public class InvalidSongNameException : InvalidSongException
{
    private const string DefaultMessage = ExceptionMessages.InvalidSongNameException;

    public InvalidSongNameException() : base(DefaultMessage)
    {
    }
}

