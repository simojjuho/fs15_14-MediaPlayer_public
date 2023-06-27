using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class VideoFile : IVideoFile
{
    private string _type;
    public string title { get; set; }
    public string director { get; set; }

    public string type
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

    public int lengthInSeconds { get; set; }
    public int playAt { get; set; }

    public VideoFile(string title, string director, string videoType, string length)
    {
        this.title = title;
        this.director = director;
        type = videoType;
    }
    
    public bool Update(string? title, string? director, string? type)
    {
        if (title != null)
        {
            this.title = title;
        }

        if (director != null)
        {
            this.director = director;
        }

        if (type != null)
        {
            this.type = type;
        }

        return true;
        
    }
}