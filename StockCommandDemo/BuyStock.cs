using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCommandDemo
{
    class BuyStock : Order
    {
        private Stock stock;

        public BuyStock(Stock stock)
        {
            this.stock = stock;
        }

        public void execute()
        {
            this.stock.Buy();
        }
    }
}
