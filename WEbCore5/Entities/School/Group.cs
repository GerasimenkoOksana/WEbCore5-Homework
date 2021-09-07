using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEbCore5.Entities.School
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Student> Students { get; set; }

        public int TeacherId { get; set; }
        [JsonIgnore]
        public Teacher Teacher { get; set; }
    }
}
