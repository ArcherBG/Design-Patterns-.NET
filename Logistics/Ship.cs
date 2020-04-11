using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivered by ship");
        }
    }
}
