using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class User : IUser
{
    private string _name;
    
    public string Id { get; }

    public string Name
    {
        get => _name;
        private set
        {
            if (value.Length < 4)
            {
                _name = value;
            }
            else
            {
                throw new ArgumentException("Name is too short");
            }
        }
    }

    public bool ChangeName(string name)
    {
        Name = name;
        return true;
    }
}