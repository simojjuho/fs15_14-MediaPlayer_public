using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Service.Interfaces;

public interface IMediaService
{
    bool AddItem(IPlayable item);

    bool RemoveItem(IPlayable item);

    IPlayable UpdateItem(IPlayable item);
}