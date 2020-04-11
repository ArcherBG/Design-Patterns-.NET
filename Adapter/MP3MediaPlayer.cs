using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MP3MediaPlayer : IMusicPlayer
    {
        public void Play(string fileName)
        {
            Console.WriteLine("Playing mp3 file: " + fileName);
        }
    }
}
