using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCommandDemo
{
    class SellStock : Order
    {
        private Stock stock;

        public SellStock(Stock stock)
        {
            this.stock = stock;
        }

        public void execute()
        {
            stock.Sell();
        }
    }
}
