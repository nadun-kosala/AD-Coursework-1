using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Models
{
    public class Cart
    {
        public int cartId { get; set; }
        public int productId { get; set; }
        public int customerId { get; set; }
        public DateTime createdAt { get; set; }
        public string productName { get; set; }
        public string category { get; set; }
        public int stockQuantity { get; set; }
        public decimal price { get; set; }
        public int cartQuantity { get; set; }
        public decimal subTotal => cartQuantity * price;
    }
}
