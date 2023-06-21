using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class VideoFile : IVideoFile
{
    public string Title { get; set; }
    public string Director { get; set; }
    public VideoType VideoType { get; set; }
    public int LengthInSeconds { get; set; }
    public int PlayAt { get; set; }

    public bool Rename()
    {
        throw new NotImplementedException();
    }
}