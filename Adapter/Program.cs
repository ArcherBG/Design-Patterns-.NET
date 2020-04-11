using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IMusicPlayer musicPlayer = new MusicPlayer();
            musicPlayer.Play("ChritmasSong.mp3");
            musicPlayer.Play("DeepHouseMix.mp4");
            musicPlayer.Play("MissionImposible.vlc");

            Console.ReadKey();
        }
    }
}
