using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Service.Interfaces;

public interface IVideoPlaylistService
{
    IVideoPlaylist VideoPlaylist { get; }

    bool AddToList(IVideoFile videoFile, string userId);

    bool RemoveFromList(IVideoFile videoFile, string userId);
}