﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.ExtraService
{
    public interface IWash
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
    }
}