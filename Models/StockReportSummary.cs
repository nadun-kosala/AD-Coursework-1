using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Models
{
    public class StockReportSummary
    {
        public int TotalProducts { get; set; }
        public int TotalUnits { get; set; }
        public decimal TotalStockValue { get; set; }
        public int LowStockCount { get; set; }
    }
}
