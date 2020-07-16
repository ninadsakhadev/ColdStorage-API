using System;
using System.Collections.Generic;
using System.Text;

namespace ColdStorage_API.Models
{
    public class HallLocation : BaseEntity
    {
        public Hall Hall { get; set; }

        public Location Location { get; set; }

    }
}
