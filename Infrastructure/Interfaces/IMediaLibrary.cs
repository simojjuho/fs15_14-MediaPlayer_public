namespace MediaPlayer.Core.Interfaces;

public interface IMediaLibrary
{
    public List<IPlayable> mediaRepository { get; set; }

    public bool AddToRepository();

    public bool RemoveFromRepository();

    public bool SortByName();
}