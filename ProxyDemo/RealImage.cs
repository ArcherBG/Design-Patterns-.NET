using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    public class ReadImage : IImage
    {
        private string fileName;

        public ReadImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk();
        }

        private void loadFromDisk()
        {
            Console.WriteLine("Loading from disk image: " + this.fileName);
        }

        public void Display()
        {
            Console.WriteLine("Display: " + this.fileName);
        }
    }
}
