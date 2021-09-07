using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEbCore5.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }

        // //отношение many:many
       // public ICollection<Product> Products { get; set; }
    }
}
