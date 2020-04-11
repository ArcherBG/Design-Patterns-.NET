using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryProducer factoryProducer = new FactoryProducer();
            AbstractFactory roundFactory = factoryProducer.getFactory(true);
            roundFactory.getShape("square").draw();
            roundFactory.getShape("rectangle").draw();

            AbstractFactory shapeFactory = factoryProducer.getFactory(false);
            shapeFactory.getShape("square").draw();
            shapeFactory.getShape("rectangle").draw();

            Console.ReadKey();
        }
    }
}
