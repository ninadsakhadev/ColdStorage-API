using System;
using System.Collections.Generic;
using System.Text;

namespace ColdStorage_API.Models
{
    public class Customer: BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        
    }
}
