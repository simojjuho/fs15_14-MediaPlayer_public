using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Infrastructure;

public class MediaRepository : IRepository
{
    private readonly List<IPlayable> _repository = new();

    private static readonly Lazy<MediaRepository> _lazy = new Lazy<MediaRepository>(() => new MediaRepository());

    private MediaRepository()
    {
    }

    public static MediaRepository Instance => _lazy.Value;

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
        var item = _repository.Find(item => item.Id == id);
        return _repository.Remove(item);
    }

    public IPlayable GetItemById(string id)
    {
        var item = _repository.Find(item => item.Id == id);
        if (item != null)
        {
            return item;
        }

        throw new ArgumentException("Wrong id");
    }

    public IPlayable UpdateItem(IPlayable update, string id)
    {
        var item = GetItemById(id);
        var updateProps = update.GetType().GetProperties();
        var oldProps = item.GetType().GetProperties();

        foreach(var property in oldProps)
        {
            if(update.GetType().GetProperty(property.Name) is not null)
            {
                if(property.CanWrite)
                {
                    property.SetValue(item, update.GetType().GetProperty(property.Name)!.GetValue(update));
                }
            }
        }

        return item;
    }
}