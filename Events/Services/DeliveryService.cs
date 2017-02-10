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
        public void ConfirmDelivery(Guid orderId)
        {
            var delivery = new Delivery { DeliveryDate = DateTime.Now, OrderId = orderId };
            EventDispatcher.Instance().Dispatch(new DeliveryConfirmedEvent { Delivery = delivery });
        }
    }
}
