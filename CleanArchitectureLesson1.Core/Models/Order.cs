﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureLesson1.Core.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
