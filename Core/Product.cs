using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWork2021.Core
{
    public class Product
    {
        public int id { get; set; }
        public string sku { get; set; }
        public string naim { get; set; }
        public string url { get; set; }
    }
}
