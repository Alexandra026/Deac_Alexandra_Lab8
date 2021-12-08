using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Deac_Alexandra_Lab8.Models;

namespace Deac_Alexandra_Lab8.Data
{
    public class Deac_Alexandra_Lab8Context : DbContext
    {

        public Deac_Alexandra_Lab8Context(DbContextOptions<Deac_Alexandra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Deac_Alexandra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Deac_Alexandra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Deac_Alexandra_Lab8.Models.Category> Category { get; set; }
        // public object Category { get; internal set; }
    }
}
