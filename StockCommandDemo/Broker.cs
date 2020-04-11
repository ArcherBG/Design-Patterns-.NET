using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCommandDemo
{
    class Broker
    {
        private List<Order> ordersList = new List<Order>();

        public void TakeOrder(Order order)
        {
            ordersList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach(Order order in ordersList)
            {
                order.execute();
            }
            ordersList.Clear();
        }
    }
}
