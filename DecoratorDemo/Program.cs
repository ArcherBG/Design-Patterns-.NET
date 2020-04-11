using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cirle cirle = new Cirle();
            cirle.Draw();

            RedDecoratedShape redCircle = new RedDecoratedShape(new Cirle());
            redCircle.Draw();

            RedDecoratedShape redSquare = new RedDecoratedShape(new Square());
            redSquare.Draw();

            Console.ReadKey();
        }
    }
}
