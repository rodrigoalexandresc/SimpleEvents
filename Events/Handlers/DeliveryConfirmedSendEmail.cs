using Events.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Handlers
{
    public class DeliveryConfirmedSendEmail : IHandler
    {
        public void Handle(dynamic e)
        {
            Console.WriteLine("Fake send e-mail :-(  :: order delivered in " + (e as DeliveryConfirmedEvent).Delivery.DeliveryDate);
        }
    }
}
