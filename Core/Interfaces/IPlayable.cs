namespace MediaPlayer.Core.Interfaces;

public interface IPlayable
{
    string Title { get; set; }
    int LengthInSeconds { get; set; }
    int PlayAt { get; set; }

    public bool Rename();
}