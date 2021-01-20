﻿using Microsoft.EntityFrameworkCore;
using SecondProjectEFCoreAttributes.Models;

namespace SecondProjectEFCoreAttributes.Contexts
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Tag> Tag { get; set; }
    }
}
