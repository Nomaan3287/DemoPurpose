﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPurpose.Models
{
    public class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }

    }
}