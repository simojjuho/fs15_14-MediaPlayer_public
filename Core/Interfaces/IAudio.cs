namespace MediaPlayer.Core.Interfaces;

public interface IAudioFile : IPlayable
{
    public string Artist { get; set; }
    public string Album { get; set; }
}