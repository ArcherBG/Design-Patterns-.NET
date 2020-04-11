using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            IShape circle = factory.getShape("circle");
            circle.draw();

            IShape square = factory.getShape("square");
            square.draw();

            Console.ReadLine();
        }
    }
}
