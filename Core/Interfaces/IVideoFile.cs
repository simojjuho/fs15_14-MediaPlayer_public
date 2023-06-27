namespace MediaPlayer.Core.Interfaces;

public interface IVideoFile : IPlayable
{
    public string director { get; set; }
    public string type { get; set; }
    
    public bool Update(string title, string director, string type);
}