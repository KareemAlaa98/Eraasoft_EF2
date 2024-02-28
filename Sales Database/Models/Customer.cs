using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Database.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string CreditCardNumber { get; set; }
        public string Email { get; set; }

        public List<Sale> Sales { get; } = new List<Sale>();
    }
}
