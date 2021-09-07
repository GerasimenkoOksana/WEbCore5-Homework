using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEbCore5.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //отношение 1:many
        public int VendorId { get; set; } 
        public Vendor Vendor { get; set; }

        //отношение many:many
        //public ICollection<Tag> Tags { get; set; }
    }
}
