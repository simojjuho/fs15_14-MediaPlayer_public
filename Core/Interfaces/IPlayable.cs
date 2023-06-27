namespace MediaPlayer.Core.Interfaces;

public interface IPlayable
{
    string Id { get; }
    string Title { get; set; }
    bool IsPlaying { get; }
    TimeSpan Length { get; }

    void Play();

    void Stop();
}