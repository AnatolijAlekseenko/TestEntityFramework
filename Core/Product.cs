using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWork2021.Core
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Naim { get; set; }
        public string Url { get; set; }

    }
}
