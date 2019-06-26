using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using trans_track.Models;

namespace trans_track.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<trans_track.Models.Vehicle> Vehicle { get; set; }
        public DbSet<trans_track.Models.Service> Service { get; set; }
        public DbSet<trans_track.Models.ServiceType> ServiceType { get; set; }
    }
}
