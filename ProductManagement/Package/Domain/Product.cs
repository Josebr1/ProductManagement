using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Package.Domain
{
    class Product
    {
        public Int64 CodProduct { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public long StockQuantity { get; set; }
        public string Characteristics { get; set; }
        public Int64 CodProvider { get; set; }
    }
}
