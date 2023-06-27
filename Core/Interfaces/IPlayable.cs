namespace MediaPlayer.Core.Interfaces;

public interface IPlayable
{
    string id { get; }
    string title { get; set; }
    int lengthInSeconds { get; set; }
    int playAt { get; set; }
}