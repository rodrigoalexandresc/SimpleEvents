using Events.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Handlers
{
    public class DeliveryConfirmedOrderUpdate : IHandler
    {
        public void Handle(dynamic e)
        {
            var myEvent = (e as DeliveryConfirmedEvent);
            myEvent.Delivery.Order.DeliveryDate = myEvent.Delivery.DeliveryDate;
            myEvent.Delivery.Order.Status = 2;
        }
    }
}
