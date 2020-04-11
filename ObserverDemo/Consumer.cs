using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class Consumer : ISubscriber
    {
        public void Update()
        {
            Console.WriteLine("Comsumer was updated");
        }
    }
}
