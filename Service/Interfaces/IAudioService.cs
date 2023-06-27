using MediaPlayer.Core;
using MediaPlayer.Core.Interfaces;
using MediaPlayer.Infrastructure;

namespace MediaPlayer.Service.Interfaces;

public interface IAudioService : IMediaService
{
    MediaRepository audioRepository { get; }

    bool AddItem(IPlayable item);
     
     bool RemoveItem(IPlayable item);

     IPlayable UpdateItem(IPlayable item);
}