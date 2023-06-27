using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class VideoFile : IVideoFile
{
    private string _type = String.Empty;
    public string Id { get; }
    public string Title { get; set; }
    public string Director { get; set; }
    public bool IsPlaying { get; private set; } = false;
    public TimeSpan Length { get; }

    public void Play()
    {
        if (!IsPlaying)
        {
            IsPlaying = true;
            Console.WriteLine($"Playing {Title} by director {Director}");
        }
    }

    public void Stop()
    {
        if (IsPlaying)
        {
            IsPlaying = false;
            Console.WriteLine("Playing stopped");   
        }
    }

    public string Type
    {
        get => _type;
        set
        {
            {
                if (value.Length > 4)
                {
                    _type = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
    
    public VideoFile(string title, string director, string videoType, TimeSpan length)
    {
        Title = title;
        Director = director;
        Type = videoType;
        var rand = new Random();
        Id = new Random().Next().ToString();
        Length = length;
    }
}