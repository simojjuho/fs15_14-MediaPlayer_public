using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class AudioFile : IAudioFile
{
    public string title { get; set; }
    public string artist { get; set; }
    public string? album { get; set; }
    public int lengthInSeconds { get; set; }
    public int playAt { get; set; }

    public AudioFile(string title, string artist, string? album)
    {
        this.title = title;
        this.artist = artist;
        if (album != null)
        {
            this.album = album;
        }
    }

    public bool Update(string? title, string? artist, string? album)
    {
        if (title != null)
        {
            this.title = title;
        }

        if (artist != null)
        {
            this.artist = artist;
        }

        if (album != null)
        {
            this.album = album;
        }

        return true;
    }


}