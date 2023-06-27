namespace MediaPlayer.Core.Interfaces;

public interface IRepository
{
    List<IPlayable> GetAllItems();
    bool AddItem(IPlayable item);

    bool RemoveItem(string id);

    IPlayable GetItemById(string id);

    IPlayable UpdateItem(IPlayable item, string id);
}