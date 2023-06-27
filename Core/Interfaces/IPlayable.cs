namespace MediaPlayer.Core.Interfaces;

public interface IPlayable
{
    string Id { get; }
    string Title { get; set; }
    int LengthInSeconds { get; set; }
    int PlayAt { get; set; }
}