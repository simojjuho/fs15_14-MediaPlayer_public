namespace MediaPlayer.Core.Interfaces;

public interface IUser
{
    string Id { get; }
    string Name { get; }

    bool ChangeName(string name);
}