using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Delivery
    {
        public Guid DeliveryId { get; set; }

        public Guid OrderId { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
