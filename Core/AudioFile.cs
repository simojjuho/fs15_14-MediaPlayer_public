using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class AudioFile : IAudioFile
{
    public string Id { get; }

    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public bool IsPlaying { get; private set; }
    public TimeSpan Length { get; }
    
    public void Play()
    {
        if (!IsPlaying)
        {
            IsPlaying = true;
            Console.WriteLine($"Playing {Title} by {Artist}");
        }    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

    public AudioFile(string title, string artist, string album, TimeSpan length)
    {
        Title = title;
        Artist = artist;
        Album = album;
        var rand = new Random();
        Id = new Random().Next().ToString();
        Length = length;
    }
}