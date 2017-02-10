using Events.Events;
using Events.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderId = Guid.NewGuid();
            var myOrder = new Order { OrderId = orderId, Status = 1, DeliveryDate = null };

            EventDispatcher.Instance().Handlers.Add(typeof(DeliveryConfirmedEvent), delivery =>
            {
                myOrder.DeliveryDate = (delivery as DeliveryConfirmedEvent).Delivery.DeliveryDate;
                myOrder.Status = 2;
            });

            Console.WriteLine(myOrder.Status + " " + myOrder.DeliveryDate);

            new DeliveryService().ConfirmDelivery(orderId);

            Console.WriteLine(myOrder.Status + " " + myOrder.DeliveryDate);

            Console.ReadKey();
        }
    }
}
