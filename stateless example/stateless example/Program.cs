using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace stateless_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new orderStates();

            order.DisplayState();

            order.fire(orderStates.Trigger.pay);
            order.fire(orderStates.Trigger.ship);
            order.fire(orderStates.Trigger.deliver);

            var newOrder = new orderStates();
            newOrder.fire(orderStates.Trigger.deliver);
            Console.ReadLine();
        }
    }
}
