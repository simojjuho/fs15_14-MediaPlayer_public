namespace MediaPlayer.Entity.Interfaces;

public interface IPlayable
{
    string Title { get; set; }
    int _lengthInSeconds { get; set; }
    int _playAt { get; set; }

    public bool Rename();
}