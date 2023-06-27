namespace MediaPlayer.Core.Interfaces;

public interface IAudioPlaylist
{
    List<IAudioFile> Playlist { get; }

    public bool AddToList(IAudioFile item, string userId);

    public bool RemoveFromList(IAudioFile item, string userId);
}