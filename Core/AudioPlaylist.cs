using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class AudioPlaylist : IAudioPlaylist
{
    public List<IAudioFile> Playlist { get; }
    private string _userId { get; }

    public AudioPlaylist(string userId)
    {
        Playlist = new();
        _userId = userId;
    }

    public bool AddToList(IAudioFile item, string userId)
    {
        Playlist.Add(item);
        if (Playlist.Contains(item) && userId == _userId)
        {
            return true;
        }

        return false;
    }

    public bool RemoveFromList(IAudioFile item, string userId)
    {
        if (userId == _userId)
        {
            return Playlist.Remove(item);
        }

        return false;
    }
}