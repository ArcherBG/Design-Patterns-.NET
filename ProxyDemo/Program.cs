using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("testImage.jpg");
            // This will load from disk
            image.Display();
            // This will load from cache.
            image.Display();

            Console.ReadKey();
        }
    }
}
