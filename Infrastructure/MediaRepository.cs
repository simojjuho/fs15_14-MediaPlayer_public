using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Infrastructure;

public class MediaRepository : IRepository
{
    private readonly List<IPlayable> _repository = new();

    private static readonly Lazy<MediaRepository> _lazy = new Lazy<MediaRepository>(() => new MediaRepository());

    private MediaRepository()
    {
    }

    public static MediaRepository instance => _lazy.Value;

    public List<IPlayable> GetAllItems()
    {
        return _repository;
    }

    public bool AddItem(IPlayable item)
    {
        _repository.Add(item);
        return true;
    }

    public bool RemoveItem(string id)
    {
        var item = _repository.Find(item => item.id == id);
        return _repository.Remove(item);
    }

    public IPlayable GetItemById(string id)
    {
        var item = _repository.Find(item => item.id == id);
        if (item != null)
        {
            return item;
        }

        throw new ArgumentException("Wrong id");
    }

    public IPlayable UpdateItem(IPlayable update, string id)
    {
        var Item = GetItemById(id);
        var UpdateProps = update.GetType().GetProperties();
        var OldProps = Item.GetType().GetProperties();

        foreach(var Property in OldProps)
        {
            if(update.GetType().GetProperty(Property.Name) is not null)
            {
                if(Property.CanWrite)
                {
                    Property.SetValue(Item, update.GetType().GetProperty(Property.Name)!.GetValue(update));
                }
            }
        }

        return Item;
    }
}