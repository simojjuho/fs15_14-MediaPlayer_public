using MediaPlayer.Core.Interfaces;
using MediaPlayer.Service.Interfaces;

namespace MediaPlayer.Service;

public class AudioPlaylistService : IAudioPlaylistService
{
    public IAudioPlaylist AudioPlaylist { get; }

    public AudioPlaylistService(IAudioPlaylist audioPlaylist)
    {
        AudioPlaylist = audioPlaylist;
    }

    public bool AddToList(IAudioFile audioFile, string userId)
    {
        return AudioPlaylist.AddToList(audioFile, userId);
    }

    public bool RemoveFromList(IAudioFile audioFile, string userId)
    {
        return AudioPlaylist.RemoveFromList(audioFile, userId);
    }
}