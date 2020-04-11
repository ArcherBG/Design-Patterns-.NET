using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Logistics
    {
        ITransport transport;

        public void PlanDelivery()
        {
            Random random = new Random();
            if ((random.Next(1, 10) % 2) == 1)
            {
                MakeDelivery("ship");
            }
            else
            {
                MakeDelivery("truck");
            }
        }

        private void MakeDelivery(string type)
        {
            if (type.Equals("ship"))
            {
                ITransport ship = new Ship();
                ship.Deliver();
            } 
            else
            {
                ITransport truck = new Truck();
                truck.Deliver();
            }
        }
    }
}
