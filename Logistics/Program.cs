using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Logistics logistics = new Logistics();

            logistics.PlanDelivery();
            logistics.PlanDelivery();

            Console.ReadLine();
        }
    }
}
