using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public int userId { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public DateTime registrationDate { get; set; }

    }
}
