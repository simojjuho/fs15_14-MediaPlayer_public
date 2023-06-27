using MediaPlayer.Core;
using MediaPlayer.Core.Interfaces;
using MediaPlayer.Infrastructure;
using MediaPlayer.Service.Interfaces;

namespace MediaPlayer.Service;

public class AudioService : IAudioService
{
    public MediaRepository audioRepository { get; private set; }

    public AudioService(MediaRepository audioRepo)
    {
        audioRepository = audioRepo;
    }
    
    public bool AddItem(IPlayable item)
    {
        return audioRepository.AddItem(item);
    }

    public bool RemoveItem(IPlayable item)
    {
        return audioRepository.RemoveItem(item.id);
    }

    public IPlayable UpdateItem(IPlayable item)
    {
        audioRepository.
    }
}