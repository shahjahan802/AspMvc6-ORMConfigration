﻿using System;
using System.Collections.Generic;

namespace ORMConfiguraitons.Models
{
    public partial class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public DateTime? DOB { get; set; }
    }
}