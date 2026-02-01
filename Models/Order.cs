using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Models
{
    public class Order
    {
        public int orderId { get; set; }

        public string orderCode { get; set; }

        public int customerId { get; set; }

        public DateTime orderDate { get; set; }

        public decimal totalAmount { get; set; }

        public decimal discountAmount { get; set; }

        public decimal finalAmount { get; set; }

        public string orderStatus { get; set; }

        public string shippingAddress { get; set; }

        public DateTime updatedAt { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
    }
}
