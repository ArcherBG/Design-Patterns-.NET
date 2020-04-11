using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Square - draw");
        }
    }
}
