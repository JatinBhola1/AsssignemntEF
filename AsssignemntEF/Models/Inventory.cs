using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsssignemntEF.Models
{
    internal class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public String Details { get; set; }
        public int QtyInStock { get; set; }
        public DateTime LastUpdated { get; set; }

        public Supplier supplier { get; set; }
    }
}
