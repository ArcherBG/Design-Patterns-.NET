using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCommandDemo
{
    class Stock
    {
        private string name = "ABC Stock";
        private int quantity = 10;

        public void Sell()
        {
            Console.WriteLine("Sell " + name + " quantity: " + quantity);
        }

        public void Buy()
        {
            Console.WriteLine("Buy " + name + " quantity: " + quantity);
        }

    }
}
