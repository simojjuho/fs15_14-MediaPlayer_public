using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Service;

public class VideoLibrary : IMediaLibrary
{
    public List<IPlayable> mediaRepository { get; set; }

    public bool AddToRepository()
    {
        throw new NotImplementedException();
    }

    public bool RemoveFromRepository()
    {
        throw new NotImplementedException();
    }

    public bool SortByName()
    {
        throw new NotImplementedException();
    }
}