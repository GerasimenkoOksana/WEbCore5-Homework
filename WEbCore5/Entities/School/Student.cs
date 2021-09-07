using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WEbCore5.Entities.School
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        [JsonIgnore]
        public Group Group { get; set; }

    }
}
