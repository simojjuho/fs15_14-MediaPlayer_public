using System.Diagnostics;

namespace MediaPlayer;

class Progaram
{
    static void Main()
    {
        ProcessStartInfo psi = new ProcessStartInfo("vlc", "./architecture-2.mp4");
        psi.UseShellExecute = false;

        Process.Start(psi);
    }
}