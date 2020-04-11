using System;

namespace Adapter
{
    internal class MP4Player : IAdvancedMediaPlayer
    {
        public void PlayMP4(string fileName)
        {
            Console.WriteLine("Playing mp4 file: " + fileName);
        }

        public void PlayVls(string fileName)
        {
            throw new System.NotImplementedException();
        }
    }
}