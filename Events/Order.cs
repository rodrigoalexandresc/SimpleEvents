using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Order
    {
        public Guid OrderId { get; set; }

        /// <summary>1-Open 2-Delivered</summary>
        public int Status { get; set; }

        public DateTime? DeliveryDate { get; set; }
    }
}
