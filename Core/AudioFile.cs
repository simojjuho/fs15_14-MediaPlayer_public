using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Core;

public class AudioFile : IAudio
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public int LengthInSeconds { get; set; }
    public int PlayAt { get; set; }

    public bool Rename()
    {
        throw new NotImplementedException();
    }
}