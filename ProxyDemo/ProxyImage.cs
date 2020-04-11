using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    public class ProxyImage : IImage
    {
        private string fileName;
        private ReadImage realImage;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if(realImage == null)
            {
                this.realImage = new ReadImage(this.fileName);
            }

            this.realImage.Display();
        }
    }
}
