using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class VideoPlaylist : IVideoPlaylist
{
    public List<IVideoFile> Playlist { get; }
    private string _userId;

    public VideoPlaylist(string userId)
    {
        Playlist = new();
        _userId = userId;
    }

    public bool AddToList(IVideoFile item, string userId)
    {
        if (userId == _userId)
        {
            Playlist.Add(item);
        }

        if (Playlist.Contains(item))
        {
            return true;
        }

        return false;
    }

    public bool RemoveFromList(IVideoFile item, string userId)
    {
        return userId == _userId && Playlist.Remove(item);
    }
}