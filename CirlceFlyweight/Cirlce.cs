using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirlceFlyweight
{
    public class Cirlce : IShape
    {
        private string color { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int radius { get; set; }

        public Cirlce(string color)
        {
            this.color = color;
        }

        public void Draw()
        {
            Console.WriteLine("Circle: color:" + color + " size x, y, radius: " + x + " " + y + " " + radius);
        }
    }
}
