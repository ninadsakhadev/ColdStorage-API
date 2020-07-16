using System;
using System.Collections.Generic;
using System.Text;

namespace ColdStorage_API.Models
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public float Rate { get; set; }
        
    }
}
