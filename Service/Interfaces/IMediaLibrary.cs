namespace MediaPlayer.Core.Interfaces;

public interface IMediaLibrary
{
    public List<IPlayable> MediaRepository { get; set; }

    public bool AddToRepository();

    public bool RemoveFromRepository();

    public bool SortByName();
}