using Events.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Services
{
    public class DeliveryService
    {
        public void ConfirmDelivery(Order order)
        {
            var delivery = new Delivery { DeliveryDate = DateTime.Now, Order = order };
            EventDispatcher.Instance().Dispatch(new DeliveryConfirmedEvent { Delivery = delivery });
        }
    }
}
