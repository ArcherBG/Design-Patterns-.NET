using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.Subscribe(new Consumer());
            publisher.Subscribe(new DifferentConsumer());

            publisher.UpdateState();

            Console.ReadKey();
        }
    }
}
