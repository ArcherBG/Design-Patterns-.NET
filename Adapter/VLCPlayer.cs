using System;

namespace Adapter
{
    internal class VLCPlayer : IAdvancedMediaPlayer
    {
        public void PlayMP4(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public void PlayVls(string fileName)
        {
            Console.WriteLine("Playing vlc file: " + fileName);
        }
    }
}