namespace MediaPlayer.Core.Interfaces;

public interface IVideoPlaylist
{
    List<IVideoFile> Playlist { get; }

    public bool AddToList(IVideoFile item, string userId);

    public bool RemoveFromList(IVideoFile item, string userId);
}