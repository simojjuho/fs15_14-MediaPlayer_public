namespace MediaPlayer.Core.Interfaces;

public interface IAudioFile : IPlayable
{
    public string artist { get; set; }
    public string album { get; set; }

    public bool Update(string title, string artist, string album);
}