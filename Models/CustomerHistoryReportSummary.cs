using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Models
{
    public class CustomerHistoryReportSummary
    {
        public int totalOrders { get; set; }
        public decimal totalSpent { get; set; }
        public decimal totalDiscounts { get; set; }
        public decimal netSpent { get; set; }
    }
}
