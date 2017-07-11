using System;

public class SongDB
{
    private int songCount;
    private long totalDurationInSeconds;

    public void AddSong(Song song)
    {
        this.songCount++;
        long totalSeconds = song.Seconds + song.Minutes * 60;
        this.totalDurationInSeconds += totalSeconds;
    }
    public override string ToString()
    {
        long totalTime = this.totalDurationInSeconds;
        long hours = totalTime / 3600;
        totalTime %= 3600;
        long minutes = totalTime / 60;
        totalTime %= 60;
        long seconds = totalTime;
        var time = $"{hours}h {minutes}m {seconds}s";
        var result = $"Songs added: {this.songCount}{Environment.NewLine}Playlist length: {time}";
        return result;
    }
}

