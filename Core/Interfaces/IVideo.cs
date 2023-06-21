namespace MediaPlayer.Core.Interfaces;

public interface IVideoFile : IPlayable
{
    public string Director { get; set; }
    public VideoType VideoType { get; set; }
}