using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WEbCore5.Entities;
using WEbCore5.Entities.School;
using WEbCore5.Models;

namespace WEbCore5.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyUser>
    {
        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
