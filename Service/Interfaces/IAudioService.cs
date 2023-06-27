using MediaPlayer.Core;
using MediaPlayer.Core.Interfaces;
using MediaPlayer.Infrastructure;

namespace MediaPlayer.Service.Interfaces;

public interface IAudioService : IMediaService
{
    MediaRepository AudioRepository { get; }
}