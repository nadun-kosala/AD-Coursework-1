using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Models
{
    public class Discount
    {
        public int discountId { get; set; }
        public string discountCode { get; set; }
        public decimal percentage { get; set; }
        public bool isActive { get; set; }
        public int maxUsageCount { get; set; }
        public int currentUsageCount { get; set; }

    }
}
