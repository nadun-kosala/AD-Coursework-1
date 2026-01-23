using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Models
{
    public class OrderDetail
    {
        public int orderDetailId { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }
        public decimal subTotal { get; set; }

    }
}
