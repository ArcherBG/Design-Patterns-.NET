using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MusicPlayer : IMusicPlayer
    {
        public void Play(string fileName)
        {
            string fileExtension = fileName.Substring(fileName.LastIndexOf('.') + 1);
            if (fileExtension.Equals("mp3"))
            {
                MP3MediaPlayer mP3MediaPlayer = new MP3MediaPlayer();
                mP3MediaPlayer.Play(fileName);
            }
            else
            {
                MediaAdapter mediaAdapter = new MediaAdapter();
                mediaAdapter.Play(fileName);
            }
        }
    }
}
