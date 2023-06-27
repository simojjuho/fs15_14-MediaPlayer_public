using MediaPlayer.Core;
using MediaPlayer.Infrastructure;

namespace MediaPlayer.Service.Interfaces;

public interface IVideoService : IMediaService
{
    MediaRepository VideoRepository { get; }
}