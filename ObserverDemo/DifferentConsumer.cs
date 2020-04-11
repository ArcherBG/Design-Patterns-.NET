using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class DifferentConsumer : ISubscriber
    {
        public void Update()
        {
            Console.WriteLine("DifferentConsumer was updated");
        }
    }
}
