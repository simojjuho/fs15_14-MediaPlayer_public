using MediaPlayer.Core;

namespace MediaPlayer.Service.Interfaces;

public interface IVideoService : IMediaService
{
    List<VideoFile> VideoRepository { get; }
}