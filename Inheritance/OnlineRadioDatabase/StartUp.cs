namespace OnlineRadioDatabase
{
    using System;
   
    public class StartUp
    {
        public static void Main()
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            var songsDB = new SongDB();
            for (int i = 0; i < numberOfSongs; i++)
            {
                var input = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var artistName = input[0];
                var songName = input[1];
                var lenght = input[2];                
                try
                {
                    var song = new Song(artistName, songName, lenght);
                    songsDB.AddSong(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(songsDB);
        }
    }
}
