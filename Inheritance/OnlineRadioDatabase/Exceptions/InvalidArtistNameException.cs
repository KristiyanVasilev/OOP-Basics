using System;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidArtistNameException : InvalidSongException
    {
        private const string DefaultMessage = ExceptionMessages.InvalidArtistNameException;
        public InvalidArtistNameException() : base (DefaultMessage)
        {

        }

        public InvalidArtistNameException(string message) : base(message)
        {

        }
    }
}




