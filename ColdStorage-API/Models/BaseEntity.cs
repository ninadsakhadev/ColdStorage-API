﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ColdStorage_API.Models
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
