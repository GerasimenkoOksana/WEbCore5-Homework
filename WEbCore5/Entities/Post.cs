using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEbCore5.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }

        //установка отношения один ко многим
       // public int CategoryId { get; set; }
        //public Category Category { get; set; } 

        //установка отношения многие ко многим
        // public ICollection<Tag> Tags { get; set; }
    }
}
