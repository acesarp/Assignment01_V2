using System;
using System.Collections.Generic;
using System.Text;
using Assign_02_V2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Assign_02_V2.Data {
    public class ApplicationDbContext : IdentityDbContext<User, AppRole, string> {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        public new DbSet<User> Users { get; set; }
        public DbSet<AppRole> AppRole { get; set; }
    }
}
