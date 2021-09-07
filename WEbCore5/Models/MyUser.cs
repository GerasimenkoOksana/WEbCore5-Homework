using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEbCore5.Models
{
    public class MyUser : IdentityUser
    {
        public int Year { get; set; }
        
    }
}
