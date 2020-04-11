using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MediaAdapter : IMusicPlayer
    {
        private IAdvancedMediaPlayer advancedMediaPlayer;

        public void Play(string fileName)
        {
            string fileExtension = fileName.Substring(fileName.LastIndexOf('.'));
            if (fileExtension.Equals("vlc"))
            {
                advancedMediaPlayer = new VLCPlayer();
                advancedMediaPlayer.PlayVls(fileName);
            }
            else if (fileExtension.Equals("mp4"))
            {
                advancedMediaPlayer = new MP4Player();
                advancedMediaPlayer.PlayMP4(fileName);
            }
        }
    }
}
