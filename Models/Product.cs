using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Models
{
    public class Product
    {
        public int id { get; set; }
        public string productName { get; set; }
        public int categoryId { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
        public int stockQuantity { get; set; }
        public int supplierId { get; set; }
        public decimal avarageRating { get; set; }
        public int totalReviews { get; set; }
        public string supplierName{ get; set; }
        public string description { get; set; }

    }
}
