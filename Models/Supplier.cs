using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Models
{
    public class Supplier
    {
        public int supplierId { get; set; }
        public string supplierName { get; set; }
        public string contactPerson { get; set; }
        public string email { get; set; }
        public string  phoneNumber { get; set; }
        public string address { get; set; }
    }
}
