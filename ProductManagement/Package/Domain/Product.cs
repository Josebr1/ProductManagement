using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Package.Domain
{

   

    class Product
    {

        private string codProduct { get; set; }
        private string description { get; set; }
        private long stockQuantity { get; set; }
        private string characteristics { get; set; }
        private long codProvider { get; set; }
    }
}
