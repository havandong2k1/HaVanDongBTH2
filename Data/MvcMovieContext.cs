using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HaVanDongBTH2.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<HaVanDongBTH2.Models.Student> Student { get; set; } = default!;

        public DbSet<HaVanDongBTH2.Models.Person>? Person { get; set; }

        public DbSet<HaVanDongBTH2.Models.Employee>? Employee { get; set; }

        public DbSet<HaVanDongBTH2.Models.Customer>? Customer { get; set; }
    }
