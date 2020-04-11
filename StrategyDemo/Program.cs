using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteStrategyAdd add = new ConcreteStrategyAdd();
            ConcreteStrategySubstract substract = new ConcreteStrategySubstract();

            Context contextAdd = new Context(add);
            Console.WriteLine("10 + 5 = " + contextAdd.ExecuteStrategy(10, 5));

            Context contextSubstract = new Context(substract);
            Console.WriteLine("20 - 8 = " + contextSubstract.ExecuteStrategy(20, 8));

            Console.ReadKey();
        }
    }
}
