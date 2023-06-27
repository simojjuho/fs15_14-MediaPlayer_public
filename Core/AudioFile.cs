using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class AudioFile : IAudioFile
{
    public string Id { get; }

    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public int LengthInSeconds { get; set; }
    public int PlayAt { get; set; }

    public AudioFile(string title, string artist, string album)
    {
        Title = title;
        Artist = artist;
        Album = album;
        var rand = new Random();
        Id = new Random().Next().ToString();
    }
}