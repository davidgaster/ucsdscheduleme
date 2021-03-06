﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ucsdscheduleme.Models;

namespace ucsdscheduleme.Data
{
    public class ScheduleContext : IdentityDbContext<ApplicationUser>
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
        {
        }

        public ScheduleContext() : base()
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Cape> Cape { get; set; }
        public DbSet<RateMyProfessor> RateMyProfessor { get; set; }
        public DbSet<UserSection> UserSections { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFTest;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>().ToTable("Course");
        }
    }
}
