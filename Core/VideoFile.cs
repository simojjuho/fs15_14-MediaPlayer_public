using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class VideoFile : IVideoFile
{
    private string _type;
    public string Id { get; }
    public string Title { get; set; }
    public string Director { get; set; }

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

    public int LengthInSeconds { get; set; }
    public int PlayAt { get; set; }

    public VideoFile(string title, string director, string videoType, string length)
    {
        Title = title;
        Director = director;
        Type = videoType;
        var rand = new Random();
        Id = new Random().Next().ToString();
    }
    
    public bool Update(string? title, string? director, string? type)
    {
        if (title != null)
        {
            this.Title = title;
        }

        if (director != null)
        {
            this.Director = director;
        }

        if (type != null)
        {
            this.Type = type;
        }

        return true;
        
    }
}