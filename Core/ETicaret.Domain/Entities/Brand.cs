﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities
{
    public class Brand
    {
        public Brand() { }
        public Brand(string name) 
        {
            Name = name; 
        }   
        public string Name { get; set; }
    }
}
