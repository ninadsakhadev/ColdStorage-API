using System;
using System.Collections.Generic;
using System.Text;

namespace ColdStorage_API.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
