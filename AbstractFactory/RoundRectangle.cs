using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class RoundRectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside RoundRectangle draw method");
        }
    }
}
