using MediaPlayer.Core;
using MediaPlayer.Core.Interfaces;
using MediaPlayer.Infrastructure;
using MediaPlayer.Service.Interfaces;

namespace MediaPlayer.Service;

public class AudioService : IAudioService
{
    public MediaRepository AudioRepository { get; private set; }

    public AudioService(MediaRepository audioRepo)
    {
        AudioRepository = audioRepo;
    }
    
    public bool AddItem(IPlayable item)
    {
        return AudioRepository.AddItem(item);
    }

    public bool RemoveItem(IPlayable item)
    {
        return AudioRepository.RemoveItem(item.Id);
    }

    public IPlayable UpdateItem(IPlayable item, string id)
    {
        return AudioRepository.UpdateItem(item, id);
    }
}