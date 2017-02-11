using Events.Events;
using Events.Handlers;
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

            EventDispatcher.Instance().AddHandler(typeof(DeliveryConfirmedEvent), new DeliveryConfirmedOrderUpdate());
            EventDispatcher.Instance().AddHandler(typeof(DeliveryConfirmedEvent), new DeliveryConfirmedSendEmail());//

            Console.WriteLine(myOrder.Status + " " + myOrder.DeliveryDate);

            new DeliveryService().ConfirmDelivery(myOrder);

            Console.WriteLine(myOrder.Status + " " + myOrder.DeliveryDate);

            Console.ReadKey();
        }
    }
}
