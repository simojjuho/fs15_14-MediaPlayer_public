using MediaPlayer.Core.Interfaces;
using MediaPlayer.Service.Interfaces;

namespace MediaPlayer.Service;

public class VideoPlaylistService : IVideoPlaylistService
{
    public IVideoPlaylist VideoPlaylist { get; }

    public VideoPlaylistService(IVideoPlaylist videoPlaylist)
    {
        VideoPlaylist = videoPlaylist;
    }

    public bool AddToList(IVideoFile videoFile, string userId)
    {
        return VideoPlaylist.AddToList(videoFile, userId);
    }

    public bool RemoveFromList(IVideoFile videoFile, string userId)
    {
        return VideoPlaylist.RemoveFromList(videoFile, userId);
    }
}