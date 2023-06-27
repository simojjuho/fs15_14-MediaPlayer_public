using MediaPlayer.Core.Interfaces;
using MediaPlayer.Infrastructure;
using MediaPlayer.Service.Interfaces;

namespace MediaPlayer.Service;

public class VideoService : IVideoService
{
    public MediaRepository VideoRepository { get; }

    public VideoService(MediaRepository videoRepository)
    {
        VideoRepository = videoRepository;
    }
    
    public bool AddItem(IPlayable item)
    {
        return VideoRepository.AddItem(item);
    }

    public bool RemoveItem(IPlayable item)
    {
        return VideoRepository.RemoveItem(item.Id);
    }

    public IPlayable UpdateItem(IPlayable item, string id)
    {
        return VideoRepository.UpdateItem(item, id);
    }
}