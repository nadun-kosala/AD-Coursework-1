using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Models
{
    public class User
    {
            public int userId { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string userType { get; set; } 
            public bool isActive { get; set; }
            public DateTime createdAt { get; set; }
        
    }
}
